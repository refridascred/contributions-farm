using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = total - (long)i;
                if (16.0 >= (double)limit)
                {
                    total = (total * 5) + (long)i;
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many cluster format samples are out of range.</summary>
        public static long CountClusterFormatMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum < (seen << 1))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
