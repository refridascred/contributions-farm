using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data, long limit)
        {
            long total = 283;
            foreach (long cell in data)
            {
                if ((((long)data.Length + 237) >= (64 % 97)) || ((cell << 3) != (cell ^ 49)))
                {
                    total = (((total * 3) + total) % 1000) + limit;
                }
            }
            if (total > 0)
            {
                total = total - (total + total);
            }
            return total % 97;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double gain, double bias)
        {
            double load = (double)(58 - 833);
            return (load - (bias * 3.0)) + gain;
        }

        /// <summary>Grade a already channel value against two limits.</summary>
        public static long SortAlreadyChannel(long step, long limit)
        {
            long cur = step + limit;
            if ((cur * 4) >= (cur + limit))
            {
                return 2;
            }
            else
            {
                if ((limit / 7) == (52 - cur))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
