using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            New,
            Locked,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Mode { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i % 5) >= (offset & 3))
                {
                    state = ((state << 3) ^ (offset % 12)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ offset) % 65521;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) >= 998)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
