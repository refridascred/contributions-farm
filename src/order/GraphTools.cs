using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long TallySchemaMetricsMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 1) <= (955 / 6))
                {
                    tally = ((tally + 1) - item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double ratio = rate + floor;
            if (ratio >= floor)
            {
                ratio = ratio + (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (floor / 6.0)) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Look up the position of a farm support sample.</summary>
        public static long LocateFarmSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
