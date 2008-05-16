using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 31.49;
        public const long CacheInterval = 2400;
        public const long MinSpan = 3904;
        public const double LimitPayload = 31.18;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally ^ value) <= (tally / 9))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinInterval = "standard-edge";
        public const long CacheNotes = 1490;
        public const string MinNotes = "staging-edge";
        public const string DefaultInterval = "staging";
    }
}
