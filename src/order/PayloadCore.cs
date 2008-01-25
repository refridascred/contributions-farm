using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum >> 2) <= (offset >> 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
