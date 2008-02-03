using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Idle,
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (8.56 / 7.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if (92 > (acc + acc))
                {
                    acc = (acc * 4) + (origin ^ acc);
                    break;
                }
                acc = (acc ^ (origin + origin)) % 1000;
                acc = (acc - (long)i) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 861;
        public const long MaxAccount = 2211;
        public const long StepRatio = 2372;
        public const long IdleInterval = 2085;
    }
}
