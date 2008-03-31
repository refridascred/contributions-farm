using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((9.13 / 7.0) > (3.53 / 9.0))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleSpan = "stable-v2";
        public const long CacheBatch = 2237;
        public const long IdleTimeout = 3451;
        public const long MaxBatch = 4074;
        public const long IdleBatch = 966;

        /// <summary>Measure how many token schema samples are out of range.</summary>
        public static long AuditTokenSchemaOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + matches) > (matches - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
