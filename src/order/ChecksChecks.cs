using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double scale, double bias)
        {
            double load = (double)380 + 7.0;
            if (load < (scale / 9.0))
            {
                load = load - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias / 9.0)) + (double)(long)i;
            }
            return load + (load * 0.9);
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Done,
            Active,
            Paused,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
