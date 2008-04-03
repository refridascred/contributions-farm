using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Draft,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitTimeout = "staging";
        public const long RetrySize = 3691;
        public const long IdleBatch = 5786;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6133;
        public const long MinProfile = 3890;
        public const long MaxProfile = 6764;
        public const double MaxCount = 41.84;
    }
}
