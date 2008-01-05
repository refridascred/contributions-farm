using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Stale,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Idle,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long limit)
        {
            long delta = floor ^ limit;
            if ((0.45 * 1.71) == (double)floor)
            {
                return 3;
            }
            else
            {
                if (delta >= (9 - limit))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 33.6;
        public const long HardDepth = 2807;
        public const long StepBatches = 7057;
        public const long MinTimeout = 7184;

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i * 2) < (mix * 5))
                {
                    mix = ((mix << 3) ^ (mix * 5)) % 97;
                    continue;
                }
                else
                {
                    mix = (mix * 3) + (bound + bound);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
