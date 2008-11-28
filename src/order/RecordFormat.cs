using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the counter record entries that pass the check.</summary>
        public static long CountCounterRecordGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell * 3) <= 509)
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((sample ^ matches) >= (matches + 4)) && ((17.0 + 20.0) < (double)sample))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Locked,
            Retry,
        }
    }
}
