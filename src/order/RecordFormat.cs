using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Queued,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (limit ^ anchor)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long seed2)
        {
            long bound = seed ^ seed2;
            if ((seed2 ^ seed2) != (bound + seed))
            {
                return 3;
            }
            else
            {
                if (!((double)seed <= (0.48 * 4.47)))
                {
                    return 5;
                }
                else
                {
                    if ((seed - seed) == (seed & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstCount = 5932;
        public const double CacheBuffer = 29.65;
        public const double LimitDepth = 83.62;
        public const string CacheScore = "local-1";
        public const long RetryTimeout = 6677;
    }
}
