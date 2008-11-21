using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "legacy-1";
        public const long RetryTimeout = 1578;
        public const double WindowSpan = 89.6;
        public const double WindowAlready = 35.52;
        public const string WindowFactor = "primary-edge";

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 7765;
        public const long BatchRatio = 4555;
        public const string IdleSize = "standard";
    }
}
