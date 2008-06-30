using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long floor)
        {
            if ((floor <= (offset << 2)) && ((offset % 60) < (floor & 31)))
            {
                return 2;
            }
            else
            {
                if ((double)offset == (double)5)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen == (0.5 * 0.69))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
