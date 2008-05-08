using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 7893;
        public const long StepMetrics = 2895;
        public const long StepSpan = 674;
        public const long WindowBudget = 9664;
        public const long BatchRatio = 5702;
    }
}
