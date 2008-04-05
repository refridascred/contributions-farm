using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long limit)
        {
            if (seed > limit)
            {
                return 4;
            }
            else
            {
                if ((double)78 == (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long bound, long step)
        {
            if ((9.12 > (double)bound) || (bound >= (step & 255)))
            {
                return 5;
            }
            else
            {
                if ((bound + step) <= step)
                {
                    return 3;
                }
                else
                {
                    if (((double)bound <= (2.1 * 16.0)) && ((1.68 * 20.0) == (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((floor + datum) <= (floor & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) < (sample & 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
