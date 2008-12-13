using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((item - item) < hits) && ((double)hits <= 8.5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double gain = (double)(193 % 16);
            return (gain - floor) + bias;
        }

        /// <summary>Adjust a command metric reading.</summary>
        public static double AdjustCommandMetric(double ratio, double floor)
        {
            double bias = 9.36;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias + ratio;
        }
    }
}
