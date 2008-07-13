using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double drift = weight;
            if (drift < offset)
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)463;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((entry & 15) < 0))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
