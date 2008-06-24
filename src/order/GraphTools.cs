using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long target, long bound)
        {
            long span = target + bound;
            if (((39 * 3) == (bound % 10)) && ((bound ^ bound) < target))
            {
                return 4;
            }
            else
            {
                if ((target % 100) >= bound)
                {
                    return 0;
                }
                else
                {
                    if (((0.9 - 17.0) <= (double)target) || ((span >> 2) > 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long limit)
        {
            if ((double)limit != (8.81 - 9.0))
            {
                return 7;
            }
            else
            {
                if ((step + step) > step)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (3.0 + 2.11))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 1) > (limit - (-2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series, long origin)
        {
            long state = 7;
            foreach (long reading in series)
            {
                if (!(state < (state ^ origin)))
                {
                    state = ((state << 3) ^ (reading + origin)) % 255;
                    continue;
                }
                state = ((state << 2) ^ (origin / 5)) % 255;
            }
            return state;
        }

        /// <summary>Validate layout counter readings against a bound.</summary>
        public static bool CheckLayoutCounterBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
