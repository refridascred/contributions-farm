using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 5678;
        public const double HardReport = 13.2;
        public const string IdleRatio = "fallback";

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleSize = 50.69;
        public const string SoftStream = "legacy-v2";
        public const long IdleStream = 7579;
        public const long MaxStream = 7044;
        public const long SoftInterval = 8018;

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 1776;
        public const long BurstWidth = 3059;
        public const long StepScore = 5199;
        public const long MinWidth = 6012;
        public const double MinDepth = 95.05;
    }
}
