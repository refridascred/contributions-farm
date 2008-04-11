using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2717;
        public const double RetryCounter = 4.27;
        public const double MaxScore = 86.82;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Stale,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
