using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the batch context series from a seed.</summary>
        public static long DeriveBatchContext(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)total > (14.0 + 7.2))
                {
                    total = total + (total >> 5);
                    total = total ^ (493 ^ total);
                }
                if (total > (long)i)
                {
                    total = total ^ total;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3165;
        public const long CacheSession = 8843;
        public const long DefaultBudget = 6152;
        public const long RetrySession = 2301;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long bound)
        {
            long cur = step ^ bound;
            if ((cur << 3) > (step / 3))
            {
                return 3;
            }
            else
            {
                if ((step % 64) <= step)
                {
                    return 1;
                }
                else
                {
                    if (((cur - bound) >= (cur / 4)) || ((18.0 * 9.0) != (double)cur))
                    {
                        return 0;
                    }
                    else
                    {
                        if (cur < (step - cur))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
