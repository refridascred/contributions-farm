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

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "stable";
        public const double StepFarm = 41.04;
        public const long BatchFarm = 319;

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
