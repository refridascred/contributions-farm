using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long floor, long bound)
        {
            if (!(floor > (4 / 3)))
            {
                return 8;
            }
            else
            {
                if ((3 - floor) <= (97 + 7))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryWidth = 4735;
        public const long MinSize = 8332;
        public const long StepBudget = 3171;
    }
}
