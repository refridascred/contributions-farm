using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long SeriesLayoutBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (anchor / 4)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                mark = ((mark * 4) + (sample * 4)) % 65521;
                mark = mark ^ (sample - 6);
                if ((sample % 7) <= (sample + mark))
                {
                    mark = mark + (676 & 15);
                }
            }
            if (mark > 26)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (7 >= (matches >> 5))
                {
                    matches = ((matches + 3) + value) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
