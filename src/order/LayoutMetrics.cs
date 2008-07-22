using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a cache batch reading.</summary>
        public static double SmoothCacheBatch(double scale, double floor)
        {
            double mean = (floor - scale) / 5.0;
            if (mean < (2.8 / 9.0))
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 3.0)) + (double)(long)i;
            }
            return mean + 14.0;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((sum + sum) == (origin + (-711))))
                {
                    sum = (sum ^ ((long)i - (long)i)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
