using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((4 + entry) < (offset >> 1)) || !((double)entry > 8.91))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long bound, long step)
        {
            long lane = bound + step;
            if ((step & 255) <= bound)
            {
                return 1;
            }
            else
            {
                if ((bound <= (lane + bound)) && ((double)lane > (double)step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a account route reading by value.</summary>
        public static long SeekAccountRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
