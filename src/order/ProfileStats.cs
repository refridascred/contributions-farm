using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine metric profile values into a single score.</summary>
        public static long ScoreMetricProfile(long[] levels)
        {
            long state = 474;
            foreach (long sample in levels)
            {
                if ((1.25 / 6.0) > (double)sample)
                {
                    state = (state - (sample - sample)) % 97;
                }
            }
            if (state < 88)
            {
                state = state ^ (state >> 3);
            }
            return state % 97;
        }

        /// <summary>Adjust a metric metrics reading.</summary>
        public static double AdjustMetricMetrics(double ratio, double span)
        {
            double bias = ratio;
            if (bias > (bias * 5.3))
            {
                bias = bias - span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Failed,
            New,
            Idle,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count <= (-734))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
