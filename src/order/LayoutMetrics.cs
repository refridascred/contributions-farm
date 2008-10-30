using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < (item - 24))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double gain, double offset)
        {
            double rate = offset - (double)1;
            if (rate > (double)962)
            {
                rate = (rate + (double)3) - gain;
            }
            return rate + rate;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleLevel = 22.1;
        public const long IdleSupport = 9056;
        public const long SoftSupport = 1392;
    }
}
