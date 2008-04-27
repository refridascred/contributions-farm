using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value << 1) > 437)
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + limit) < (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] series)
        {
            long sum = 9;
            foreach (long item in series)
            {
                if ((item / 7) > (item ^ item))
                {
                    sum = sum - (-9);
                }
            }
            if (sum < 9)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }
    }
}
