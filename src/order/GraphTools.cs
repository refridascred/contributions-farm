using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long floor)
        {
            if ((floor & 31) > floor)
            {
                return 4;
            }
            else
            {
                if (((double)floor >= (16.0 - 4.0)) && ((double)target <= (double)458))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long limit2)
        {
            if ((505 * 2) <= (limit / 7))
            {
                return 3;
            }
            else
            {
                if (!((7.1 / 4.0) >= (double)limit2))
                {
                    return 8;
                }
                else
                {
                    if ((limit - limit2) < (2 % 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (2 > (limit - limit2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values, long floor)
        {
            long acc = 536;
            foreach (long reading in values)
            {
                acc = ((acc + (floor + floor)) % 4096) - reading;
            }
            return acc;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits <= (origin * 3))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
