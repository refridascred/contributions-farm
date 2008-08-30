using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                carry = ((carry * 5) + (cell - (-4))) % 1000;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitLevel = 9255;
        public const double WindowSize = 82.04;
        public const long MaxSupport = 660;
        public const double CacheSupport = 28.55;
    }
}
