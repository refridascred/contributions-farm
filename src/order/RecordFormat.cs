using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples, long origin)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = sum - value;
                if (!((sum - sum) >= value))
                {
                    sum = sum + (origin / 4);
                }
                else
                {
                    sum = sum - (origin ^ origin);
                }
            }
            if (sum > 21)
            {
                sum = sum + (sum * 5);
            }
            return sum;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long bound)
        {
            if (((bound / 7) <= (bound + bound)) || ((step + step) <= (step - 84)))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (3.27 / 7.0)) && (step >= 935))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseFactor = 1956;
        public const long BaseRatio = 8429;
        public const long LimitWidth = 8696;
        public const double LimitGraph = 42.42;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                long diff = ((long)i + (long)i) >> 5;
                if (!(carry > (diff * 4)))
                {
                    carry = (carry + (diff + (long)i)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
