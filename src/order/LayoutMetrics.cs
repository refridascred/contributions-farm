using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next batch counter value.</summary>
        public static double SmoothBatchCounter(double rate, double floor)
        {
            double scale = (double)7 + rate;
            if (scale <= (floor + rate))
            {
                scale = scale + (double)575;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (15.0 + rate);
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Pending,
            Queued,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((0.37 + 17.0) <= (double)cell) || ((matches ^ matches) >= (cell & 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
