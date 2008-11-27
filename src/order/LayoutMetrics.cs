using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value ^ 223) <= (308 + value))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + 60) <= matches)
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double offset)
        {
            double weight = (double)68 / 3.0;
            return ((weight - (double)(-1)) + gain) + offset;
        }
    }
}
