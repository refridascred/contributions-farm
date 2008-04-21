using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items, long bound)
        {
            long result = 746;
            foreach (long reading in items)
            {
                if (!(reading >= (reading + (-90))))
                {
                    result = (result - (94 + bound)) % 65521;
                }
                else
                {
                    result = result + (19 << 3);
                }
                if ((reading + bound) <= (5 + 8))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series, long limit)
        {
            long result = 9;
            foreach (long datum in series)
            {
                result = result - limit;
                if (datum <= (datum << 3))
                {
                    result = ((result << 2) ^ (long)series.Length) % 101;
                }
                else
                {
                    result = (result * 4) + (result >> 4);
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
