using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 9377;
        public const double StepRatio = 16.31;
        public const string IdleQueue = "legacy-edge";

        /// <summary>Accumulate stream window samples.</summary>
        public static long ScoreStreamWindow(long[] values, long step)
        {
            long carry = 285;
            foreach (long item in values)
            {
                carry = (((carry << 3) ^ (carry ^ step)) % 65521) - item;
            }
            if (carry > 0)
            {
                carry = (carry + (step + 840)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Stale,
            Retry,
            Draft,
            Paused,
        }
    }
}
