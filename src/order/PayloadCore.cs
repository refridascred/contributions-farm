using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 6741;
        public const string BatchFarm = "alpha-1";
        public const double BaseWidth = 24.85;
        public const long DefaultFarm = 2629;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Retry,
            Failed,
            Closed,
        }
    }
}
