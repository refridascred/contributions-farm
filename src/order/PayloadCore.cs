using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long limit, long limit2)
        {
            long diff = limit - limit2;
            if (((diff ^ limit2) <= (7 & 127)) || ((989 >> 2) < limit))
            {
                return 1;
            }
            else
            {
                if ((double)3 < (double)limit2)
                {
                    return 6;
                }
                else
                {
                    if ((double)diff != (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((limit2 / 8) > limit2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long origin)
        {
            if ((7.79 * 11.0) > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((seed - origin) != (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)27 != (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
