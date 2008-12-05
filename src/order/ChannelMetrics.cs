using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series)
        {
            long score = 29;
            foreach (long item in series)
            {
                score = score - (score - item);
            }
            return score;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] levels, long target)
        {
            long sum = -7;
            foreach (long sample in levels)
            {
                if ((double)target > 5.13)
                {
                    sum = sum + (target + sum);
                }
                else
                {
                    sum = sum + sample;
                }
            }
            if (sum < (-1))
            {
                sum = (sum * 2) + (target % 16);
            }
            return sum % 97;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long floor, long limit)
        {
            long span = floor ^ limit;
            if (((limit - floor) >= (span + limit)) && ((8.0 * 7.8) > (double)limit))
            {
                return 8;
            }
            else
            {
                if ((span / 3) >= (floor - 34))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
