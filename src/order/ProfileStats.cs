using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Idle,
            Dropped,
            Locked,
            New,
            Failed,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] levels)
        {
            long state = 53;
            foreach (long value in levels)
            {
                state = (state + 2) % 65521;
                if ((state / 4) < value)
                {
                    state = state ^ (388 - value);
                }
                state = (state + (value + value)) % 101;
            }
            if (state > 86)
            {
                state = (state ^ 73) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample - hits) >= (offset + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
