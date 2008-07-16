using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Pending,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 2) ^ (72 & 1)) % 1000;
                carry = (carry + (long)i) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultFactor = 4775;
        public const long RetrySession = 7801;
        public const double CacheWidth = 80.21;
        public const long IdleTimeout = 2389;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
