using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long origin)
        {
            if ((step <= (8 - step)) && ((origin / 4) == (origin % 100)))
            {
                return 4;
            }
            else
            {
                if (!(1 > origin))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Rank { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
