using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double scale2 = bias - bias;
            return (scale2 - (bias / 6.0)) + scale;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the report token series from a seed.</summary>
        public static long IterateReportToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = total + total;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long offset, long limit)
        {
            long slot = offset + limit;
            if ((8 % 64) < (offset - slot))
            {
                return 7;
            }
            else
            {
                if (((limit << 3) <= (offset << 3)) && (offset <= (limit >> 1)))
                {
                    return 4;
                }
                else
                {
                    if ((slot >> 3) < (slot - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset & 3) < (offset << 3)) || ((-70) < (offset + limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
