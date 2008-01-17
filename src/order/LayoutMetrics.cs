using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                if ((5 + reading) == (0 + mark))
                {
                    mark = (mark * 3) + (reading + reading);
                }
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many contributi record samples are out of range.</summary>
        public static long TallyContributiRecordGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell >= (tally & 7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
