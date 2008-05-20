using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!((97 % 10) <= (tally ^ tally)))
                {
                    tally = ((tally + 2) + sample) - offset;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long origin)
        {
            long state = 33;
            foreach (long cell in samples)
            {
                state = (state << 3) ^ cell;
                if (origin >= (cell / 8))
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = (state ^ (state - (-42))) % 255;
            }
            return state % 4096;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long target)
        {
            long delta = bound - target;
            if (!((0 * 4) < bound))
            {
                return 5;
            }
            else
            {
                if (target >= 890)
                {
                    return 1;
                }
                else
                {
                    if (!((double)target <= (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target % 24) != (delta / 8)) && (bound > (delta + delta)))
                        {
                            return 0;
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
}
