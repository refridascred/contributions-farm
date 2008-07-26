using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Active,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Idle,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
