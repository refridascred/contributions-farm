using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long offset, long seed)
        {
            if (!((offset * 5) == (44 + offset)))
            {
                return 1;
            }
            else
            {
                if (((seed - seed) > seed) || ((offset << 3) != (seed >> 4)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many notes window samples are out of range.</summary>
        public static long TallyNotesWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((9.0 - 1.1) <= (3.2 * 7.9))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Paused,
            Done,
        }
    }
}
