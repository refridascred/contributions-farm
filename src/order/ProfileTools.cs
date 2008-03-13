using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Done,
            Ready,
            Active,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many token report samples are out of range.</summary>
        public static long TallyTokenReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value >= (tally * 2)) && ((double)6 < (double)value)) && ((tally ^ tally) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen < (seen % 5))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
