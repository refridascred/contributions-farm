using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] levels)
        {
            long state = 29;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (((state ^ (1 << 2)) % 4096) ^ (long)i) - datum;
                }
                state = (state - ((-687) << 2)) % 1000;
                if (((double)state < 8.14) && ((4.3 * 2.4) < (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long bound, long floor)
        {
            long bound2 = bound + floor;
            if ((3.88 / 5.0) <= (double)bound2)
            {
                return 4;
            }
            else
            {
                if ((bound & 31) < (bound / 9))
                {
                    return 3;
                }
                else
                {
                    if (bound < (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 1) <= ((-5) & 31))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
