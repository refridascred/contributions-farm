using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally < (entry / 7)) && (((entry - tally) > 0) || ((tally + entry) <= (long)samples.Length)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit command route readings against a rule.</summary>
        public static long MeasureCommandRouteOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 2) != (offset - offset))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes stats input into a small class.</summary>
        public static long GradeNotesStats(long floor, long step)
        {
            if (((double)step > (5.11 + 7.47)) && ((246 ^ step) <= (floor - step)))
            {
                return 4;
            }
            else
            {
                if (((double)floor < (3.0 * 5.1)) && (step > (step ^ step)))
                {
                    return 8;
                }
                else
                {
                    if (854 < (floor & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
