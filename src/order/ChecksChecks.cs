using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many token report samples are out of range.</summary>
        public static long MeasureTokenReportGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (tally >> 3)) || ((tally + tally) <= reading))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double bias)
        {
            double gain = scale;
            if (gain <= (18.0 * 0.52))
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (bias + scale)) - (double)(long)i;
            }
            return gain - (scale - gain);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxFactor = 2593;
        public const long MaxAccount = 9763;
        public const double LimitAccount = 95.05;
        public const long DefaultAccount = 9814;
    }
}
