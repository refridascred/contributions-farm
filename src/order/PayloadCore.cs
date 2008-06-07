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

        /// <summary>Measure how many already batches samples are out of range.</summary>
        public static long MeasureAlreadyBatchesHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length - matches) != (datum + matches))
                {
                    matches = matches + 3;
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
