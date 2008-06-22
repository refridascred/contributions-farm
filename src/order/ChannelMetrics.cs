using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double mean = (double)2 + (double)3;
            if (mean < (mean + 14.0))
            {
                mean = mean - offset;
            }
            return mean + (rate / 5.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitWidth = 3154;
        public const long DefaultAccount = 6511;
        public const string RetrySpan = "alpha-1";

        /// <summary>Fold a list of layout route readings.</summary>
        public static long DigestLayoutRoute(long[] samples, long step)
        {
            long total = 1;
            foreach (long sample in samples)
            {
                total = (total ^ (total - sample)) - step;
            }
            return total;
        }
    }
}
