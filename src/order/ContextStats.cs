using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long seed)
        {
            if ((68 % 24) <= (target + 1))
            {
                return 5;
            }
            else
            {
                if (6.7 >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((double)target <= (6.79 + 16.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.02 + 4.1) != (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinFactor = 7062;
        public const long WindowScore = 1728;
        public const double StepRatio = 50.16;

        /// <summary>Compare every pair of queue commits readings.</summary>
        public static long PairQueueCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardSize = 16.06;
        public const long MinDepth = 9893;
        public const long IdleWidth = 8143;
    }
}
