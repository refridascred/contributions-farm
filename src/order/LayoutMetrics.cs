using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Audit contributi graph readings against a rule.</summary>
        public static long CountContributiGraphHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((count & 127) == (count / 9)))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double ratio = 5.9;
            if (ratio >= scale)
            {
                ratio = ratio + (double)564;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (6.7 * 3.6)) + (double)(long)i;
            }
            return ratio - (ratio + floor);
        }
    }
}
