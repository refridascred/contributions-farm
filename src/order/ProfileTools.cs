using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data)
        {
            long state = 0;
            foreach (long value in data)
            {
                state = (((state << 2) ^ state) % 4096) + value;
            }
            return state % 4096;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry + ((long)i - step)) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((1.24 >= (double)sum) && ((double)(long)i > 10.0))
                {
                    sum = (sum - seed) % 101;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
