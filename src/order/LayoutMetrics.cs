using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long origin)
        {
            if ((floor + origin) > ((-4) - floor))
            {
                return 1;
            }
            else
            {
                if ((double)floor != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin == (6.03 + 3.14))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor % 64) < (origin << 2)) && ((double)floor < (double)71))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + acc) % 97;
                acc = (acc ^ ((long)i << 3)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading / 5) == ((-44) - 534))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
