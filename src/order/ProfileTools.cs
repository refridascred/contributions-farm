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

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] data)
        {
            long sum = 5;
            foreach (long entry in data)
            {
                sum = ((sum * 2) + ((long)data.Length % 10)) % 97;
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum * 3) + entry) + (long)i;
                }
                if ((entry ^ entry) <= (entry * 4))
                {
                    sum = ((sum * 2) + entry) % 4096;
                }
                else
                {
                    sum = (sum ^ (93 - sum)) % 255;
                }
            }
            if (sum < 702)
            {
                sum = ((sum * 5) + (sum & 15)) % 255;
            }
            return sum % 4096;
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
