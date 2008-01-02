using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long limit)
        {
            long step = origin - limit;
            if (limit < (origin & 1))
            {
                return 4;
            }
            else
            {
                if ((step + limit) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((step + origin) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if (!!(((long)i & 3) == ((long)i / 8)))
                {
                    score = (score * 4) + score;
                    score = (score ^ (long)i) % 1000;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Failed,
            Queued,
        }
    }
}
