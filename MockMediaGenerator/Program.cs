using System;
using System.Collections.Generic;
using System.IO;

var mode = args.Length > 0 ? args[0].ToLowerInvariant() : "album";
var outputDir = args.Length > 1 ? args[1] : Path.Combine(Directory.GetCurrentDirectory(), "MockOutput");
int? count = null;
if (args.Length > 2 && int.TryParse(args[2], out var parsedCount))
{
    count = parsedCount;
}

Directory.CreateDirectory(outputDir);

Console.WriteLine($"Mode: {mode}");
Console.WriteLine($"Output: {outputDir}");
if (count.HasValue)
    Console.WriteLine($"Count: {count.Value}");

var random = new Random();

switch (mode)
{
    case "album":
        GenerateMockAlbum(outputDir, count ?? 12, random);
        break;
    case "roms":
        GenerateMockRoms(outputDir, count ?? 30, random);
        break;
    case "tv":
        GenerateMockTvEpisodes(outputDir, count ?? 10, random);
        break;
    default:
        Console.WriteLine("Unknown mode. Use: album | roms | tv");
        break;
}

Console.WriteLine("Done.");

static void GenerateMockAlbum(string dir, int trackCount, Random random)
{
    var artistNames = new[]
    {
        "The Paper Steps", "Neon Skyline", "Midnight Static", "Analog Echoes"
    };

    var albumTitles = new[]
    {
        "Lined Pages", "Dotted Dreams", "Graph Paper Nights", "Ink & Footsteps"
    };

    var trackWords = new[]
    {
        "Steps", "Pages", "Moon", "Lights", "Echo", "Circuit", "Rain",
        "Skyline", "Static", "Lines", "Margins", "Notes", "Signals"
    };

    var years = new[] { 2018, 2019, 2020, 2021, 2022, 2023 };

    string artist = artistNames[random.Next(artistNames.Length)];
    string album = albumTitles[random.Next(albumTitles.Length)];
    int year = years[random.Next(years.Length)];

    // Some album download–style prefixes/suffixes
    string[] qualityTags = { "[WEB-320]", "[FLAC]", "[V0]", "[WEB]", "[CD]" };
    string tag = qualityTags[random.Next(qualityTags.Length)];

    Console.WriteLine($"Generating mock album: {artist} - {album} ({year}) {tag}");

    for (int i = 1; i <= trackCount; i++)
    {
        string trackTitle = $"{Pick(trackWords, random)} {Pick(trackWords, random)}";
        string fileName = $"{artist} - {year} - {album} - {i:00} - {trackTitle} {tag}.mp3";

        string fullPath = Path.Combine(dir, SanitizeFileName(fileName));
        WriteMockFile(fullPath);
    }
}

static void GenerateMockRoms(string dir, int romCount, Random random)
{
    var systemNames = new[]
    {
        "NES", "SNES", "MegaDrive", "GBA", "N64", "DreamBox"
    };

    var gameWords = new[]
    {
        "Adventure", "Quest", "Legend", "Star", "Galaxy", "Island", "Mystery",
        "Racer", "Battle", "Heroes", "Kingdom", "Chronicles", "Rumble"
    };

    var regions = new[]
    {
        "USA", "Europe", "Japan", "World"
    };

    var langs = new[]
    {
        "En", "Fr", "De", "Es", "It", "Ja", "Pt"
    };

    var exts = new[]
    {
        ".zip", ".7z", ".rar"
    };

    for (int i = 0; i < romCount; i++)
    {
        string system = systemNames[random.Next(systemNames.Length)];
        string gameTitle = $"{Pick(gameWords, random)} of {Pick(gameWords, random)}";
        string region = regions[random.Next(regions.Length)];

        // Sometimes add languages
        string langTag = random.NextDouble() < 0.5
            ? $"({Pick(langs, random)},{Pick(langs, random)})"
            : $"({Pick(langs, random)})";

        // Sometimes add extra dump-style tags
        string dumpTag = random.NextDouble() < 0.5 ? "(Rev A)" : "";
        string goodDump = random.NextDouble() < 0.3 ? "[!]" : "";

        string baseName = $"{gameTitle} ({region}) {langTag} {dumpTag} {goodDump}"
            .Replace("  ", " ").Trim();

        string fileName = $"{baseName}{exts[random.Next(exts.Length)]}";

        string folderForSystem = Path.Combine(dir, system);
        Directory.CreateDirectory(folderForSystem);

        string fullPath = Path.Combine(folderForSystem, SanitizeFileName(fileName));
        WriteMockFile(fullPath);
    }
}

static void GenerateMockTvEpisodes(string dir, int episodeCount, Random random)
{
    // Fake TV show
    string showName = "Galactic.Paper.Steps";
    int season = 1;

    string[] sources = { "WEB-DL", "BluRay", "WEBRip" };
    string[] resolutions = { "720p", "1080p", "2160p" };
    string[] codecs = { "x264", "x265" };
    string[] groups = { "P2D", "P2-GRP", "P2HD" };

    for (int ep = 1; ep <= episodeCount; ep++)
    {
        string resolution = Pick(resolutions, random);
        string source = Pick(sources, random);
        string codec = Pick(codecs, random);
        string group = Pick(groups, random);

        string fileName =
            $"{showName}.S{season:00}E{ep:00}.{resolution}.{source}.{codec}-{group}.mkv";

        string folder = Path.Combine(dir, $"{showName}.S{season:00}");
        Directory.CreateDirectory(folder);

        string fullPath = Path.Combine(folder, SanitizeFileName(fileName));
        WriteMockFile(fullPath);
    }
}

static string Pick(string[] array, Random random)
{
    return array[random.Next(array.Length)];
}

static string SanitizeFileName(string name)
{
    foreach (var c in Path.GetInvalidFileNameChars())
    {
        name = name.Replace(c, '_');
    }
    return name;
}

static void WriteMockFile(string path)
{
    // Create a small placeholder file
    var content = $"Mock file: {Path.GetFileName(path)}{Environment.NewLine}Generated at {DateTime.Now}";
    File.WriteAllText(path, content);
}
