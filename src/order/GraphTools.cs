using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long seed)
        {
            if ((5 >> 2) > floor)
            {
                return 7;
            }
            else
            {
                if ((floor + seed) >= 89)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Mode { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((double)item >= (5.16 + 9.8)))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Synced,
            Retry,
            Ready,
            Paused,
        }
    }
}
