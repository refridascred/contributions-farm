using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((1.4 / 4.0) > (double)sum)
                {
                    sum = sum ^ ((long)i - sum);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((reading % 24) >= (hits * 2)) && (((reading + (-460)) == (limit / 5)) && ((double)limit <= (double)reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Audit filter queue readings against a rule.</summary>
        public static long TallyFilterQueueHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((double)limit < (8.0 * 8.72)) || (((long)values.Length / 6) >= (limit * 4))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
