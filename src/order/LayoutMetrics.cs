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

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long acc = 5;
            foreach (long sample in readings)
            {
                if (((0.47 - 7.81) >= (7.65 / 2.0)) && (sample >= (sample + sample)))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
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
