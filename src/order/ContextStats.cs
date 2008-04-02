using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry & 3) <= (matches % 5))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Match up cache payload samples.</summary>
        public static long PairCachePayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long floor)
        {
            if (step > (2 % 7))
            {
                return 8;
            }
            else
            {
                if ((floor ^ step) >= (869 - floor))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
