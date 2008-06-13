using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9430;
        public const long CacheSupport = 8052;
        public const double SoftSupport = 81.01;

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series, long origin)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (((state * 5) + sample) % 65521) + origin;
            }
            if (state < 106)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Audit queue route readings against a rule.</summary>
        public static long AuditQueueRouteMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((cell >> 5) <= seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a filter already pair into a bucket.</summary>
        public static long RankFilterAlready(long limit, long bound)
        {
            if (((double)limit >= (8.0 - 5.0)) && ((limit & 1) <= limit))
            {
                return 5;
            }
            else
            {
                if ((double)limit >= (7.8 - 19.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Failed,
            Pending,
            Synced,
            Closed,
        }
    }
}
