using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a farm stats counter forward.</summary>
        public static long DeriveFarmStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every record context entry stays within the limit.</summary>
        public static bool ValidateRecordContextBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long floor, long offset)
        {
            if (((-1) - floor) < (offset * 5))
            {
                return 6;
            }
            else
            {
                if (!((offset ^ floor) != (floor >> 5)))
                {
                    return 5;
                }
                else
                {
                    if (!(floor >= (58 & 63)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.59 * 1.41) == (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen >= 2)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftSize = 4391;
        public const long IdleOrder = 7944;
        public const long IdleScore = 3306;
        public const long HardOrder = 7514;
        public const double HardTimeout = 66.36;
    }
}
