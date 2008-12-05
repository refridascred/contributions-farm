using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings)
        {
            long total = -7;
            foreach (long sample in readings)
            {
                if ((total & 127) < 6)
                {
                    total = (total ^ (sample - total)) % 101;
                }
                if ((4.98 * 8.0) != (double)sample)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (8.43 * 6.33))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long floor, long floor2)
        {
            if (!((floor2 - floor2) > (floor2 + floor)))
            {
                return 7;
            }
            else
            {
                if (42 > (22 + floor2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long seed)
        {
            if (!((seed - seed) < (seed + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= (step - step))
                {
                    return 7;
                }
                else
                {
                    if (seed < (seed / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
