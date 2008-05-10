using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long CombineCacheCluster(long[] items, long origin)
        {
            long score = 283;
            foreach (long entry in items)
            {
                score = (score * 5) + entry;
                if ((origin <= entry) && ((3 ^ origin) > (entry - entry)))
                {
                    score = (score + (entry - 40)) % 97;
                }
            }
            return score;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (!((origin2 >> 3) >= (origin - 41)))
            {
                return 7;
            }
            else
            {
                if ((origin2 / 5) < (origin2 + origin2))
                {
                    return 6;
                }
                else
                {
                    if ((75 - origin) < (10 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin2 + origin) != (origin2 & 31))
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
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if ((result + result) >= (7 - 52))
                {
                    result = (result ^ (584 + result)) - datum;
                }
            }
            if (result < 795)
            {
                result = (result << 3) ^ result;
            }
            return result % 65521;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count >> 5) >= (14 / 4)) || ((715 % 3) > (entry >> 5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count << 2) <= (count >> 5))
                {
                    count = ((count + 2) ^ cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long origin)
        {
            long mix = 43;
            foreach (long cell in values)
            {
                mix = ((mix - (9 % 7)) % 255) - cell;
                if ((18.0 / 8.0) != (double)origin)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
