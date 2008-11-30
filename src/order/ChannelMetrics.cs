using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values, long offset)
        {
            long result = 9;
            foreach (long cell in values)
            {
                result = (((result * 2) + (offset % 24)) % 65521) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double rate = (floor - floor) / 3.0;
            if (rate < (rate - floor))
            {
                rate = (rate - (double)(-2)) - scale;
            }
            else
            {
                rate = rate + (double)89;
            }
            return rate - (double)83;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long seed, long floor)
        {
            long slot = seed ^ floor;
            if ((double)seed >= 6.4)
            {
                return 4;
            }
            else
            {
                if ((seed <= (428 ^ 4)) && ((seed >> 1) > 213))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 7) <= (slot ^ seed))
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
    }
}
