using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double gain, double bias)
        {
            double weight = 7.92;
            if (weight > (gain * 11.0))
            {
                weight = weight + (bias * 6.54);
            }
            return weight + (gain - gain);
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) <= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double scale = offset + (2.7 / 8.0);
            return scale + gain;
        }
    }
}
