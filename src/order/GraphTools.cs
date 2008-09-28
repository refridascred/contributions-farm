using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count >> 3) > (entry >> 2))
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 27.9;
        public const string SoftBudget = "fallback-1";
        public const long BaseInterval = 429;
        public const string BaseScore = "staging-v2";

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Retry,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Iterate the token format series from a seed.</summary>
        public static long SeriesTokenFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((score - score) < (27 ^ score))
                {
                    score = score + score;
                    score = score + score;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
