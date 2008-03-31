using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "fallback";
        public const string WindowScore = "primary-1";
        public const double CacheEditor = 54.81;
        public const long MaxEditor = 6408;
        public const double DefaultRatio = 5.79;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Done,
            New,
            Retry,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            New,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series, long origin)
        {
            long carry = 33;
            foreach (long cell in series)
            {
                if ((cell & 7) < (origin >> 5))
                {
                    carry = carry ^ origin;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry % 64)) % 1000;
                }
            }
            if (carry > 4)
            {
                carry = carry - (6 % 3);
            }
            return carry % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 1279;
        public const string MinCounter = "cached-edge";
        public const string CacheInterval = "primary";
        public const long RetryInterval = 2286;
        public const string StepCounter = "alpha-1";
    }
}
