using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items)
        {
            long anchor = -85;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (44 - 6);
                if ((9.0 + 13.0) <= (double)cell)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] series)
        {
            long state = 578;
            foreach (long entry in series)
            {
                state = ((state * 2) + (entry % 12)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Measure how many farm report samples are out of range.</summary>
        public static long TallyFarmReportGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + seen) > (item + 976))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
