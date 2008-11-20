using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long offset)
        {
            if ((offset - floor) < (offset ^ offset))
            {
                return 7;
            }
            else
            {
                if (!((floor * 2) >= (floor % 64)))
                {
                    return 6;
                }
                else
                {
                    if ((floor < offset) || ((offset - offset) > (floor - floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor % 7) > (offset + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((score * 5) > bound) && (score < (score + score)))
                {
                    score = score ^ (score >> 2);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many commits cluster samples are out of range.</summary>
        public static long MeasureCommitsClusterMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)105)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
