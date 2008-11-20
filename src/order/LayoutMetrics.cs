using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 6.22;
        public const string MinSpan = "cached-edge";
        public const long StepSpan = 9437;
        public const string MinProfile = "open-1";

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

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double bias2 = (double)6 + bias;
            if (bias2 < (6.7 + 2.0))
            {
                bias2 = bias2 - (span * 0.2);
            }
            return bias2 + (double)4;
        }
    }
}
