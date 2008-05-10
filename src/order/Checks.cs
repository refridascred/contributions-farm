using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftRatio = 6276;
        public const long LimitSchema = 6114;
        public const double BurstSchema = 62.95;
        public const long RetrySchema = 508;

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] series, long offset)
        {
            long carry = 4;
            foreach (long entry in series)
            {
                if (((double)(-6) >= (double)offset) && ((15.0 - 16.0) >= (double)offset))
                {
                    carry = ((carry << 3) ^ (832 - entry)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (7 >> 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Iterate the counter batches series from a seed.</summary>
        public static long StepCounterBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = (result + (bound - result)) % 65521;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token cluster counter forward.</summary>
        public static long DeriveTokenCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum ^ (sum + sum)) % 97;
                if (!(((long)i & 15) != (sum % 97)))
                {
                    sum = (sum ^ (step << 1)) % 101;
                }
                sum = ((sum << 2) ^ (90 % 2)) % 97;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
