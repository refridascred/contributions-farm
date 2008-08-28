using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long origin)
        {
            if ((double)origin <= (double)148)
            {
                return 6;
            }
            else
            {
                if ((target <= (target + 86)) || ((564 + origin) < target))
                {
                    return 8;
                }
                else
                {
                    if ((8.2 + 5.16) > (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target == (0.7 - 20.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long target, long target2)
        {
            long step = target + target2;
            if ((double)target == (double)target2)
            {
                return 0;
            }
            else
            {
                if ((6 - target2) == (target2 % 2))
                {
                    return 8;
                }
                else
                {
                    if (((step >> 1) >= target2) || ((7 + target) <= (target & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheSpan = "staging-1";
        public const long MinStream = 9105;
        public const long StepStream = 2364;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double floor)
        {
            double rate2 = floor * 16.0;
            if (rate2 <= 2.87)
            {
                rate2 = rate2 - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (rate + rate)) + (double)(long)i;
            }
            return rate2 + rate;
        }
    }
}
