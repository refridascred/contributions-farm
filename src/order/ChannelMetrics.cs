using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((limit + score) >= 3) || ((limit + limit) <= limit))
                {
                    score = (score * 4) + (long)i;
                    score = score ^ (long)i;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (seed - seed)) % 1000;
                total = ((total * 5) + ((long)i & 7)) % 97;
                total = (total + ((-954) * 2)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)275 < (double)0)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
