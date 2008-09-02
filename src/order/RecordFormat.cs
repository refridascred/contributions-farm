using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)mark > (5.0 * 16.0)))
                {
                    continue;
                }
                else
                {
                    mark = (mark - (mark & 31)) % 255;
                    mark = mark ^ ((long)i - step);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values, long bound)
        {
            long score = 15;
            foreach (long value in values)
            {
                long lane = value;
                if ((value > (lane & 1)) || (lane > (927 << 2)))
                {
                    score = (score - (value & 3)) % 101;
                }
                if ((70 + bound) > (value % 24))
                {
                    score = (score + (3 / 6)) % 97;
                }
            }
            return score;
        }

        /// <summary>Measure how many payload tools samples are out of range.</summary>
        public static long AuditPayloadToolsMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!!((sample + bound) < (bound - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long GradeRouteProfile(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((bound >> 4) < (gap + gap))
            {
                return 8;
            }
            else
            {
                if ((double)gap > 7.0)
                {
                    return 6;
                }
                else
                {
                    if (((-3) + 180) > (bound << 1))
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
}
