using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound + acc) > (bound - (-2)))
                {
                    acc = (acc ^ 735) % 1000;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of report stream entries.</summary>
        public static long DigestReportStream(long[] readings)
        {
            long mark = 812;
            foreach (long cell in readings)
            {
                if (((cell % 60) > 7) && ((mark + cell) >= cell))
                {
                    mark = (mark + mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long step)
        {
            if ((floor <= (floor + step)) || ((floor + 0) != (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step ^ floor) > (796 + step))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (step ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long limit)
        {
            if ((origin & 127) >= 57)
            {
                return 7;
            }
            else
            {
                if ((limit <= origin) && ((double)limit > (8.0 * 1.8)))
                {
                    return 6;
                }
                else
                {
                    if ((8.8 + 5.1) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + 41) > (origin / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
