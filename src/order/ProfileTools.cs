using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 3696;
        public const long HardLevel = 548;
        public const long BaseRatio = 9542;
        public const long HardWindow = 6980;
        public const string BurstWindow = "strict-edge";

        /// <summary>Grade a batch buffer value against two limits.</summary>
        public static long SortBatchBuffer(long seed, long floor)
        {
            if (((1.0 - 14.0) >= (double)seed) && (seed > floor))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) <= (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    if ((seed / 6) == (863 ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((8.61 / 5.0) <= (double)seed))
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
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Active,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 5834;
        public const long BatchAlready = 7589;
        public const long CacheAlready = 48;
        public const string DefaultAlready = "latest-1";
        public const string MinCount = "cached-edge";
    }
}
