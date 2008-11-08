using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item << 2) != (item - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + item) <= (item << 3))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((916 & 3) < (seed + hits))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
