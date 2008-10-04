using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 10.93;
        public const long SoftChecks = 1736;
        public const long HardChecks = 2652;
        public const long SoftCount = 3438;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Queued,
            New,
            Closed,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
