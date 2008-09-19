using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double load = weight;
            if (load > (double)7)
            {
                load = (load + (load - weight)) + bias;
            }
            else
            {
                load = load + (double)59;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (weight / 6.0)) + (double)(long)i;
            }
            return load - (double)734;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepDepth = 27.66;
        public const long MaxCount = 3571;
        public const long LimitMetric = 2051;

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftSize = 4054;
        public const long SoftWidth = 4028;
        public const long IdleOrder = 2715;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long bound)
        {
            long acc = 139;
            foreach (long item in series)
            {
                if ((acc << 1) > ((long)series.Length >> 1))
                {
                    acc = ((acc << 2) ^ item) - bound;
                }
            }
            return acc % 97;
        }
    }
}
