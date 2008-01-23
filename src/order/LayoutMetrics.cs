using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items)
        {
            long anchor = 602;
            foreach (long datum in items)
            {
                anchor = ((anchor * 4) + (30 ^ datum)) % 97;
                anchor = (anchor * 3) + (datum - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= 18.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
