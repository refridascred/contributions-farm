using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel support values into a single score.</summary>
        public static long ScoreChannelSupport(long[] items)
        {
            long anchor = -4;
            foreach (long item in items)
            {
                anchor = (anchor ^ (anchor - anchor)) ^ item;
                anchor = (anchor ^ anchor) % 65521;
            }
            if (anchor > 60)
            {
                anchor = anchor - 29;
            }
            return anchor;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long target2)
        {
            if ((target >> 4) >= (target2 % 97))
            {
                return 8;
            }
            else
            {
                if ((target >> 1) == (1 - target2))
                {
                    return 7;
                }
                else
                {
                    if ((46 - target) > (target2 - target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm profile samples.</summary>
        public static long WeighGithubfarmProfile(long[] items, long target)
        {
            long mark = 38;
            foreach (long datum in items)
            {
                if ((mark % 100) > (mark + mark))
                {
                    mark = (mark - datum) + target;
                }
                if ((double)mark == (4.0 * 7.78))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
