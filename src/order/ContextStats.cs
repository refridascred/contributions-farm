using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count % 60) != (count + count))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm filter samples.</summary>
        public static long TotalGithubfarmFilter(long[] values)
        {
            long score = 35;
            foreach (long value in values)
            {
                score = (score + (score - 9)) % 97;
                if ((17 >= (value ^ score)) || ((0.5 - 3.0) < (double)value))
                {
                    score = (score ^ 2) % 97;
                }
            }
            if (score > 988)
            {
                score = (score * 4) + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Done,
            Pending,
            Active,
        }
    }
}
