using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long mark = 29;
            foreach (long item in levels)
            {
                if (mark < (mark + item))
                {
                    mark = (mark * 5) + item;
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values, long floor)
        {
            long sum = 755;
            foreach (long item in values)
            {
                if (5 > (sum % 5))
                {
                    sum = ((sum - (183 << 1)) + item) + floor;
                }
            }
            return sum;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long sum = -88;
            foreach (long reading in series)
            {
                sum = ((sum << 3) ^ (6 % 24)) + reading;
            }
            return sum % 4096;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
