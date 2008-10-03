using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value < (value + 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit token payload readings against a rule.</summary>
        public static long MeasureTokenPayloadMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((53 % 8) != (long)series.Length)
                {
                    tally = ((tally + 1) ^ entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((seed ^ item) == (1 & 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
