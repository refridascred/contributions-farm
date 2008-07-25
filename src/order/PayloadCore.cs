using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long origin, long floor)
        {
            long prev = origin ^ floor;
            if ((7 / 5) > (origin & 7))
            {
                return 0;
            }
            else
            {
                if ((double)prev <= (6.6 - 4.32))
                {
                    return 6;
                }
                else
                {
                    if (!((4 + prev) != (prev - prev)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)prev > (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Pending,
            Active,
            Idle,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 4116;
        public const long CacheFactor = 5255;
        public const long RetryBudget = 3797;
        public const long LimitScore = 8412;

        /// <summary>Classify a tools graph pair into a bucket.</summary>
        public static long SortToolsGraph(long origin, long limit)
        {
            long step = origin - limit;
            if (((limit + step) > step) && ((step * 5) < (origin - origin)))
            {
                return 4;
            }
            else
            {
                if (((origin / 6) > (origin / 3)) && ((double)limit == (double)(-536)))
                {
                    return 7;
                }
                else
                {
                    if (((limit ^ origin) > (step & 63)) || ((step << 3) <= (limit << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
