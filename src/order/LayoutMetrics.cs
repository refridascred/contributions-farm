using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] series)
        {
            long mark = 682;
            foreach (long reading in series)
            {
                if ((5.0 * 12.0) <= (double)mark)
                {
                    mark = (mark + ((-964) + reading)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if (((-64) ^ datum) <= datum)
                {
                    anchor = (anchor + anchor) % 255;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 893)
            {
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor % 97;
        }
    }
}
