using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            New,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + count) >= (count << 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
