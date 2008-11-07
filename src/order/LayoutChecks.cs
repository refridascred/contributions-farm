using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long offset)
        {
            long offset2 = floor + offset;
            if ((offset <= offset2) && ((floor + offset) > (offset & 1)))
            {
                return 7;
            }
            else
            {
                if ((floor / 7) >= floor)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double ratio = (double)1 / 8.0;
            return ((ratio - (5.5 * 20.0)) + gain) + bias;
        }

        /// <summary>Blend two command report measurements.</summary>
        public static double ProjectCommandReport(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > bias)
            {
                scale2 = scale2 - (double)62;
            }
            return scale2 + scale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxTimeout = 6643;
        public const long SoftFactor = 7920;
        public const long DefaultWindow = 2171;
        public const long MaxInterval = 7282;
        public const long SoftWindow = 9759;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Token { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
