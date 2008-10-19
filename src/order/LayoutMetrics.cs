using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank commits payload input into a small class.</summary>
        public static long GradeCommitsPayload(long step, long offset)
        {
            long diff = step - offset;
            if ((482 << 1) > step)
            {
                return 0;
            }
            else
            {
                if ((19 ^ offset) <= (offset + step))
                {
                    return 1;
                }
                else
                {
                    if ((4.9 - 3.1) > (double)diff)
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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long bound)
        {
            if ((double)origin < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound & 31) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (((origin & 1) < (origin + bound)) && ((bound - 0) <= ((-668) - origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) > (origin / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long CountGraphChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 1) < (matches + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
