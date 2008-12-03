using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstSpan = "local";
        public const long WindowContext = 9215;
        public const string BurstContext = "legacy-1";
        public const long DefaultSpan = 7495;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Closed,
            Ready,
            New,
            Locked,
        }
    }
}
