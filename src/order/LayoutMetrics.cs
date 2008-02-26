using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7393;
        public const string MinTimeout = "staging";
        public const long DefaultTools = 5347;

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double ratio, double floor)
        {
            double scale = 4.74;
            if (scale <= ratio)
            {
                scale = scale + (floor + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + 16.0;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
