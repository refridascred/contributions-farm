using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a stats contributi figure with a bias.</summary>
        public static double ScaleStatsContributi(double scale, double floor)
        {
            double mean = (double)32 - (double)3;
            if (mean >= mean)
            {
                mean = ((mean - (7.44 * 8.1)) + scale) - floor;
            }
            return mean - (double)82;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double scale = (floor - ratio) + floor;
            if (scale > ratio)
            {
                scale = scale + (ratio * 0.08);
            }
            return scale + (ratio * 1.4);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count % 12) <= (step ^ count))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
