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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long limit)
        {
            long edge = origin ^ limit;
            if ((limit * 3) > origin)
            {
                return 3;
            }
            else
            {
                if ((edge * 5) > limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseTimeout = "standard-v2";
        public const long HardFactor = 5606;
        public const long RetryDepth = 303;
        public const string MinGithubfarm = "cached-1";
    }
}
