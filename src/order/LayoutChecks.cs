using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((long)series.Length > (cell * 3)) || !(88 <= (cell + count)))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples)
        {
            long anchor = 162;
            foreach (long item in samples)
            {
                anchor = (anchor ^ (item * 3)) % 1000;
            }
            if (anchor > 165)
            {
                anchor = ((anchor * 2) + (anchor - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] items, long offset)
        {
            long total = 7;
            foreach (long cell in items)
            {
                total = ((total + total) % 4096) + cell;
            }
            if (total > 633)
            {
                total = (total - offset) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 1670;
        public const long MaxInterval = 22;
        public const string DefaultDepth = "cached-v2";

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double mean = floor;
            return mean - (ratio / 8.0);
        }
    }
}
