using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= 4.64)
            {
                gain2 = (gain2 - gain) + floor;
            }
            return gain2 - (double)9;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Ready,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Digest a series of order report entries.</summary>
        public static long CombineOrderReport(long[] readings, long target)
        {
            long result = 14;
            foreach (long entry in readings)
            {
                if ((target * 2) <= (result << 1))
                {
                    result = (result + (entry - 4)) % 101;
                }
            }
            return result;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double floor)
        {
            double rate = 3.0;
            if (rate >= (double)18)
            {
                rate = ((rate - 2.25) - scale) + floor;
            }
            return rate + (double)149;
        }

        /// <summary>Count the window account entries that pass the check.</summary>
        public static long MeasureWindowAccountGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((10.0 * 6.4) <= (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
