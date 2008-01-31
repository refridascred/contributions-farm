using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((bound << 1) <= (-78)) && ((bound / 4) <= bound))
                {
                    result = (result + bound) % 1000;
                    result = (result - (8 >> 4)) % 97;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (19.0 - 7.71))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long origin2)
        {
            long slot = origin + origin2;
            if (((5.0 + 9.9) > (double)origin) || (slot < ((-56) - 3)))
            {
                return 8;
            }
            else
            {
                if (!((301 + slot) > origin2))
                {
                    return 3;
                }
                else
                {
                    if ((origin < (origin + 75)) && ((origin2 + slot) < (origin / 5)))
                    {
                        return 0;
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
