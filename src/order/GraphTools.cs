using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long bound)
        {
            if (((double)limit >= (7.3 * 9.0)) && ((limit * 3) < (5 - 343)))
            {
                return 6;
            }
            else
            {
                if ((-1) >= (limit + bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound < (8.23 - 1.49))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstLevel = 7844;
        public const long MaxBudget = 4936;
        public const double MaxCounter = 28.14;

        /// <summary>Classify a batch support pair into a bucket.</summary>
        public static long BucketBatchSupport(long bound, long limit)
        {
            if (((bound & 127) < (bound - bound)) && ((2.67 * 0.9) < (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound > (bound - bound)) && ((bound + bound) <= (limit - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound > (limit ^ limit)) && ((limit % 12) < (limit % 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a buffer farm pair into a bucket.</summary>
        public static long SortBufferFarm(long seed, long offset)
        {
            long gap = seed ^ offset;
            if (((gap & 255) >= (48 << 1)) && (111 >= (seed << 3)))
            {
                return 0;
            }
            else
            {
                if ((offset & 31) > (seed << 3))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed < (3.86 * 8.0)) || ((double)gap > (0.4 * 3.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
