using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                long edge = (long)i;
                if (!(((double)target <= (9.4 / 6.0)) || (target >= (target + edge))))
                {
                    edge = ((edge << 2) ^ state) % 4096;
                    state = ((state * 2) + ((-4) & 63)) % 101;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitDepth = 5339;
        public const long RetryWidth = 624;
        public const long BurstSupport = 1363;
        public const long CacheBudget = 8372;
        public const long DefaultSupport = 426;

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "standard-v2";
        public const long StepSpan = 6995;
        public const long SoftChecks = 4853;

        /// <summary>Compare every pair of cluster farm readings.</summary>
        public static long OverlapClusterFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first contributi commits entry that matches the target.</summary>
        public static long SeekContributiCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
