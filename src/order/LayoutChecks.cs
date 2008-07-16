using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every route githubfarm entry stays within the limit.</summary>
        public static bool GuardRouteGithubfarmRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading != (10.0 + 7.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long target2)
        {
            long gap = target + target2;
            if (((8.6 * 1.89) <= (double)gap) || ((38 + gap) >= (target2 + target2)))
            {
                return 0;
            }
            else
            {
                if (target2 > (gap / 2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long limit, long origin)
        {
            if (!(limit > (limit / 3)))
            {
                return 3;
            }
            else
            {
                if (((origin - limit) <= 51) && ((double)origin > (6.0 - 20.0)))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 3) >= ((-9) & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long WeighRecordPayload(long[] samples)
        {
            long state = 0;
            foreach (long item in samples)
            {
                if (!((876 / 7) != (state >> 5)))
                {
                    state = (state << 3) ^ (item % 12);
                    break;
                }
                if ((item + 78) == (item / 9))
                {
                    state = (state - (item % 3)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ item;
                }
            }
            return state;
        }
    }
}
