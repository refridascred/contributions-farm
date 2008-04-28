using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Synced,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 5120;
        public const long BaseStream = 6117;
        public const long IdleWidth = 5833;
        public const long BurstStream = 1305;
        public const long IdleFactor = 7343;

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] values)
        {
            long acc = 25;
            foreach (long value in values)
            {
                if (acc >= (acc + value))
                {
                    acc = (acc ^ (value + acc)) % 1000;
                }
                if (!((7.16 + 2.0) <= (double)value))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
