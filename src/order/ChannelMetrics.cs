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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen >> 2) < seen)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }
    }
}
