using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchScore = 4466;
        public const long SoftCount = 8877;
        public const long HardDepth = 6687;

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowScore = 280;
        public const long BatchStats = 6999;
        public const string BurstScore = "fallback-1";
        public const long StepSpan = 7074;
        public const long RetryInterval = 9482;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Count the already stream entries that pass the check.</summary>
        public static long AuditAlreadyStreamGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((seed >> 2) > (86 + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
