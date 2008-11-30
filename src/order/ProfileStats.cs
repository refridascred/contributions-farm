using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long origin)
        {
            if ((double)bound != (6.9 - 2.51))
            {
                return 8;
            }
            else
            {
                if (8.7 <= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (bound > (origin << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((11.0 + 8.96) < (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cluster tools series from a seed.</summary>
        public static long SeriesClusterTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor + sum) >= (sum + 64))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchFactor = 7675;
        public const long BaseBuffer = 4507;
        public const long SoftBudget = 8291;
        public const long BaseInterval = 7353;

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
