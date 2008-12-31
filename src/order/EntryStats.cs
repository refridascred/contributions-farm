using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] data)
        {
            long score = 19;
            foreach (long entry in data)
            {
                score = (score ^ (score - score)) % 4096;
                if ((entry % 8) >= (score & 127))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
