using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit checks queue readings against a rule.</summary>
        public static long CountChecksQueueOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (floor < 791)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Draft,
            Synced,
            Stale,
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
