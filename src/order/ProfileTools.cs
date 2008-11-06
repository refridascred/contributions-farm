using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the graph notes entries that pass the check.</summary>
        public static long TallyGraphNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(((entry >> 3) != ((-4) + tally)) || (entry <= (entry * 5))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Ready,
            Synced,
            Idle,
        }
    }
}
