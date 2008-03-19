using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 1950;
        public const string BurstRecord = "stable";
        public const long LimitRecord = 1550;
        public const long SoftRecord = 493;
        public const double StepLevel = 93.46;

        /// <summary>Blend two entry window measurements.</summary>
        public static double AdjustEntryWindow(double rate, double bias)
        {
            double scale = rate;
            return (scale + scale) + bias;
        }
    }
}
