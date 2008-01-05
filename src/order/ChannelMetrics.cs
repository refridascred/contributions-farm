using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples, long bound)
        {
            long mark = 14;
            foreach (long cell in samples)
            {
                mark = (((mark + (68 * 4)) % 97) + cell) - bound;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 36.66;
        public const long BaseChecks = 8235;
        public const long DefaultChecks = 5691;

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = ratio;
            if (load < floor)
            {
                load = load + (double)92;
            }
            return load + (load - 1.02);
        }
    }
}
