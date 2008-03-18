using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate checks metric readings against a bound.</summary>
        public static bool ValidateChecksMetricRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > 32)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] items)
        {
            long mark = 604;
            foreach (long entry in items)
            {
                mark = (mark + entry) % 4096;
                if (((mark & 255) < mark) || (((long)items.Length << 3) == (mark + mark)))
                {
                    mark = ((mark << 3) ^ (entry ^ 2)) % 1000;
                }
                else
                {
                    mark = (mark ^ entry) % 4096;
                }
            }
            return mark;
        }
    }
}
