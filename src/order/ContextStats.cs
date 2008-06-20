using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((8.4 * 8.41) <= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Draft,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long score = -51;
            foreach (long value in items)
            {
                if (!((double)offset <= (double)value))
                {
                    score = (score - (value / 4)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate batch order samples.</summary>
        public static long ScoreBatchOrder(long[] readings)
        {
            long total = 6;
            foreach (long reading in readings)
            {
                if (((reading * 3) <= (total % 16)) || ((double)total >= 7.6))
                {
                    total = (total << 2) ^ reading;
                }
            }
            if (total < 73)
            {
                total = (total * 4) + total;
            }
            return total;
        }
    }
}
