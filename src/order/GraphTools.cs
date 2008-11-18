using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long bound, long bound2)
        {
            if ((75 ^ bound2) <= (bound2 >> 3))
            {
                return 4;
            }
            else
            {
                if ((bound2 - bound2) > bound2)
                {
                    return 1;
                }
                else
                {
                    if ((bound & 63) <= (bound2 & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - item) >= (item * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (4 < (hits - hits))
                {
                    hits = ((hits + 2) + entry) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "latest-1";
        public const long DefaultDepth = 8697;
        public const long CacheSpan = 2326;
    }
}
