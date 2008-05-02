using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the contributi cache entries that pass the check.</summary>
        public static long MeasureContributiCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((34 - matches) <= matches)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 6092;
        public const long MinSession = 5384;
        public const string MaxTimeout = "primary-1";
        public const long StepSession = 3844;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
