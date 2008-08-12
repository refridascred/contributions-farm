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

        /// <summary>Count the schema route entries that pass the check.</summary>
        public static long CountSchemaRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally >> 4) <= value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
