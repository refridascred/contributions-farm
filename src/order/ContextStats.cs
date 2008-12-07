using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a batches payload pair into a bucket.</summary>
        public static long BucketBatchesPayload(long target, long target2)
        {
            long prev = target - target2;
            if ((double)target <= (1.3 - 17.0))
            {
                return 3;
            }
            else
            {
                if ((target ^ prev) != (target + target2))
                {
                    return 8;
                }
                else
                {
                    if ((target2 % 8) >= (6 - 682))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                long next = seed * 4;
                if (!((next % 24) == (seed % 7)))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Draft,
            Ready,
            Active,
        }
    }
}
