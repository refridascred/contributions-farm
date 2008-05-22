using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 2436;
        public const double StepSize = 75.57;
        public const string RetrySpan = "staging-v2";

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Closed,
            Stale,
            Done,
        }
    }
}
