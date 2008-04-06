using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many entry window samples are out of range.</summary>
        public static long MeasureEntryWindowMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + cell) < (limit - limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool ValidateGraphCounterRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a format payload value against two limits.</summary>
        public static long GradeFormatPayload(long step, long origin)
        {
            if (!(origin < (step * 5)))
            {
                return 4;
            }
            else
            {
                if (((step % 7) <= origin) && ((origin ^ origin) >= (1 & 15)))
                {
                    return 3;
                }
                else
                {
                    if (((9.0 + 7.1) == (double)origin) || (step < (step + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (8.0 * 8.63))
                        {
                            return 5;
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
