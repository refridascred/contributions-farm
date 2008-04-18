using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (-2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mark = 59;
            foreach (long value in samples)
            {
                mark = ((mark * 3) + (value + mark)) % 101;
                mark = mark + (46 & 31);
                if ((mark + value) > mark)
                {
                    mark = (mark - (value & 31)) % 255;
                }
                else
                {
                    mark = mark ^ (value + value);
                }
                if ((value << 1) == (value + 8))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data, long offset)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = ((mix - (86 >> 5)) - item) - offset;
            }
            return mix % 1000;
        }
    }
}
