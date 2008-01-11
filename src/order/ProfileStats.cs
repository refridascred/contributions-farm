using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits batch series from a seed.</summary>
        public static long StepCommitsBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = state - (415 + 1);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 9874;
        public const string BaseCache = "legacy-1";
        public const double LimitCache = 54.65;
        public const double RetryCache = 97.07;
        public const long StepCache = 634;
    }
}
