using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits entry samples are out of range.</summary>
        public static long TallyCommitsEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value <= (value + value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((bound + 99) < (160 - count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Failed,
            Pending,
            Draft,
            Ready,
        }
    }
}
