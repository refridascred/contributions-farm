using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxRatio = 8118;
        public const string WindowInterval = "legacy-edge";
        public const string LimitGraph = "cached";
        public const double BatchCount = 17.9;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 4031;
        public const string CacheContributi = "open-v2";
        public const double DefaultContributi = 55.07;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((matches >> 4) < matches) || (((1 ^ matches) > cell) || (matches > (342 / 2))))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
