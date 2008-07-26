using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next checks token value.</summary>
        public static double AdjustChecksToken(double bias, double span)
        {
            double weight = 15.0;
            if (weight >= (bias + weight))
            {
                weight = (weight - bias) - span;
            }
            return weight - bias;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((double)datum == (12.0 / 9.0)) && ((tally * 5) < (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
