using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + seed) % 101;
                if ((long)i < (9 & 15))
                {
                    result = ((result * 3) + seed) % 101;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 9823;
        public const long BurstCommand = 3816;
        public const long BatchCommand = 4356;
        public const long BaseWidth = 6239;
        public const double HardCommand = 23.3;

        /// <summary>Classify a already tools pair into a bucket.</summary>
        public static long SortAlreadyTools(long step, long step2)
        {
            if ((step + step2) != (77 >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)775 > (double)step2)
                {
                    return 1;
                }
                else
                {
                    if ((-1) <= (step + step2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step * 2) > (-85)) && ((0.6 / 8.0) <= (double)step2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Dropped,
            Active,
        }
    }
}
