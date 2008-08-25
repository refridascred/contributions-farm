using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two record stream measurements.</summary>
        public static double SmoothRecordStream(double bias, double offset)
        {
            double rate = offset + (bias + bias);
            if (rate > (rate * 1.0))
            {
                rate = rate + (rate / 2.0);
            }
            return rate + (rate + bias);
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a layout githubfarm value against two limits.</summary>
        public static long SortLayoutGithubfarm(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((double)seed2 > (6.39 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((diff >> 2) <= (diff / 7))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
