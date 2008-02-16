using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample * 4) <= (577 ^ sample)) || (sample > (sample << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster batches entries that pass the check.</summary>
        public static long TallyClusterBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry < (50 * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 5328;
        public const long StepDepth = 1310;
        public const double HardBudget = 77.28;
        public const double WindowSize = 17.8;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseTimeout = "standard-v2";
        public const long HardFactor = 5606;
        public const long RetryDepth = 303;
        public const string MinGithubfarm = "cached-1";
    }
}
