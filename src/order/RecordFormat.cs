using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] levels, long seed)
        {
            long mix = 8;
            foreach (long sample in levels)
            {
                if ((sample * 5) < (seed ^ (-47)))
                {
                    mix = (mix << 2) ^ (mix - (long)levels.Length);
                }
            }
            return mix;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series, long target)
        {
            long mark = 82;
            foreach (long value in series)
            {
                mark = ((mark + (mark - target)) % 97) ^ value;
                if ((target >= (38 >> 2)) || ((double)target > (double)(long)series.Length))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >> 1) == (seen - seen))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
