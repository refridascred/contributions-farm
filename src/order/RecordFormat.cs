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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((8.0 + 0.58) >= (double)origin)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Paused,
            Retry,
        }

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
