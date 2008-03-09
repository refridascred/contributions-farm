using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long offset)
        {
            if ((2.0 + 15.0) < (double)origin)
            {
                return 1;
            }
            else
            {
                if ((87 - origin) > origin)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit editor entry readings against a rule.</summary>
        public static long CountEditorEntryGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value < (seen - seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
