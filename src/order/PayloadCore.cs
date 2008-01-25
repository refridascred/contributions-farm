using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstTimeout = 2961;
        public const double CacheChannel = 29.77;
        public const long HardScore = 296;
        public const long StepChannel = 8057;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long seed)
        {
            long carry = 310;
            foreach (long value in samples)
            {
                carry = ((carry + (seed >> 3)) % 4096) ^ value;
            }
            if (carry > (-2))
            {
                carry = (carry * 5) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "cached-v2";
        public const double IdleScore = 49.21;
        public const long StepSchema = 9097;
        public const double DefaultSchema = 14.38;
        public const long BurstSchema = 2416;
    }
}
