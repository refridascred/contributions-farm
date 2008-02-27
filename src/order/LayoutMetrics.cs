using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double bias = floor;
            return bias + (scale + scale);
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
