using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftFactor = 36.44;
        public const long WindowProfile = 2106;
        public const string MinWidth = "local";
        public const long LimitProfile = 1631;
        public const long LimitRatio = 7194;

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowLevel = "alpha-edge";
        public const string SoftRatio = "primary-1";
        public const long BaseLevel = 1521;
        public const double MaxTimeout = 59.18;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Closed,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state << 2) ^ 243;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
