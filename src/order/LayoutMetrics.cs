using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first format order entry that matches the target.</summary>
        public static long LookupFormatOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((long)i >= (limit * 4)))
                {
                    long cur = 2 ^ limit;
                    total = total - (cur * 4);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }
    }
}
