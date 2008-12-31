using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample > (count & 31)) || ((double)sample <= (double)count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
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
