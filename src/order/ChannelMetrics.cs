using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] values)
        {
            long acc = 372;
            foreach (long cell in values)
            {
                acc = (acc ^ (acc + acc)) + cell;
            }
            return acc;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double ratio, double span)
        {
            double rate = ratio - (4.92 * 5.2);
            if (rate <= (ratio + rate))
            {
                rate = (rate + rate) - span;
            }
            else
            {
                rate = rate + (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (double)472;
        }
    }
}
