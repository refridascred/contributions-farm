using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + (359 - anchor);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 1240;
        public const string RetryNotes = "open";
        public const long SoftSpan = 1850;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (9.0 > (double)cell)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
