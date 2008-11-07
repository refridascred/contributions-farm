using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long origin)
        {
            long next = floor + origin;
            if ((floor << 1) != (next * 2))
            {
                return 0;
            }
            else
            {
                if ((next * 2) != (origin / 6))
                {
                    return 1;
                }
                else
                {
                    if ((next << 3) < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((next >> 5) == (next << 3)) && ((origin & 15) >= 710))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
