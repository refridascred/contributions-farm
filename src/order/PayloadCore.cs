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

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((carry % 100) > carry)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
