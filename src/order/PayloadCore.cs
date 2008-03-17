using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-657) >> 5) != (count * 5))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Rank support format input into a small class.</summary>
        public static long BucketSupportFormat(long floor, long target)
        {
            long slot = floor - target;
            if ((target % 3) == (441 + slot))
            {
                return 7;
            }
            else
            {
                if ((89 + slot) < floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor + slot) >= (503 % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7.98 - 9.9) > (double)slot)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long limit)
        {
            if ((804 ^ limit) != (5 << 2))
            {
                return 7;
            }
            else
            {
                if ((origin << 2) > origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double weight, double offset)
        {
            double mean = offset - (double)990;
            if (mean <= (double)770)
            {
                mean = (mean + offset) - weight;
            }
            else
            {
                mean = mean + offset;
            }
            return mean + offset;
        }
    }
}
