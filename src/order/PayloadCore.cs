using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 9657;
        public const long IdleContext = 7577;
        public const long StepTimeout = 8345;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 16.01;
        public const long BatchSize = 5059;
        public const double DefaultEntry = 45.31;
        public const long StepSize = 421;
    }
}
