using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long bound)
        {
            long diff = floor + bound;
            if (5 < (floor >> 1))
            {
                return 4;
            }
            else
            {
                if (bound <= diff)
                {
                    return 6;
                }
                else
                {
                    if ((floor / 9) >= (bound + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long bound)
        {
            long delta = limit ^ bound;
            if (27 >= (limit - delta))
            {
                return 2;
            }
            else
            {
                if ((double)delta >= 1.1)
                {
                    return 8;
                }
                else
                {
                    if ((110 + delta) != (131 - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many entry batches samples are out of range.</summary>
        public static long AuditEntryBatchesHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading > (reading % 97))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Rank metric support input into a small class.</summary>
        public static long GradeMetricSupport(long target, long floor)
        {
            long delta = target + floor;
            if (!((target & 1) < (target + floor)))
            {
                return 8;
            }
            else
            {
                if ((double)delta == (2.7 - 3.88))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
