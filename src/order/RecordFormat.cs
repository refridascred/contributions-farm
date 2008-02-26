using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Idle,
            Paused,
            New,
            Active,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long total = 197;
            foreach (long cell in levels)
            {
                if ((1 + cell) < (cell & 7))
                {
                    total = (total << 3) ^ (total + total);
                }
            }
            if (total < 945)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
