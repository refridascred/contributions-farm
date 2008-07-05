using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long origin)
        {
            long mark = 25;
            foreach (long item in readings)
            {
                if ((double)mark == (0.9 + 1.41))
                {
                    mark = (mark + (origin << 1)) % 101;
                }
                if ((item + mark) != (mark >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)matches > 3.51) && ((11.0 - 0.9) == (double)matches))
                {
                    matches = ((matches + 2) - entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double gain = ratio;
            return (gain - ratio) + floor;
        }
    }
}
