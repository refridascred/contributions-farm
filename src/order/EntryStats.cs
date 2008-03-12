using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Pending,
            New,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score * 5) + (932 % 3)) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if ((offset2 * 3) <= (offset2 ^ floor))
            {
                return 6;
            }
            else
            {
                if ((offset * 5) != (offset2 << 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
