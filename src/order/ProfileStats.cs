using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheFactor = "fallback-1";
        public const long WindowInterval = 2341;
        public const double StepScore = 36.2;
        public const long IdleCounter = 6733;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((carry << 1) <= (seed + (long)i)) || (carry > 6))
                {
                    carry = (carry - (carry + 33)) % 65521;
                }
                carry = (carry << 3) ^ (carry << 3);
                if (!(((long)i / 6) <= (carry - carry)))
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Pending,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Classify a queue stats pair into a bucket.</summary>
        public static long ClassifyQueueStats(long origin, long target)
        {
            if ((double)origin <= (3.0 + 7.4))
            {
                return 4;
            }
            else
            {
                if ((target > (origin ^ target)) && (origin > (target + origin)))
                {
                    return 7;
                }
                else
                {
                    if (((93 * 4) != (target >> 2)) && ((6.3 + 18.0) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
