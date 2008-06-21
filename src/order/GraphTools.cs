using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 2690;
        public const long BaseTimeout = 1854;
        public const double DefaultLevel = 74.09;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((tally * 5) == (item + item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits << 1) > (13 * 4))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double floor)
        {
            double gain = (floor / 9.0) - floor;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain + (bias * 8.9);
        }
    }
}
