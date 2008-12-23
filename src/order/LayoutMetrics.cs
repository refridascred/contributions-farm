using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "standard-edge";
        public const long BaseMetrics = 9744;
        public const long HardMetrics = 9609;
        public const long WindowMetrics = 194;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Retry,
            Draft,
            Stale,
        }

        /// <summary>Validate checks editor readings against a bound.</summary>
        public static bool GuardChecksEditorRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
