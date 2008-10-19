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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((item / 5) == (8 % 24)) || ((double)bound > 8.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 16.01;
        public const long BatchSize = 5059;
        public const double DefaultEntry = 45.31;
        public const long StepSize = 421;
    }
}
