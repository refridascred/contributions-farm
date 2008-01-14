using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 76.35;
        public const long IdleScore = 3456;
        public const string StepRatio = "stable";
        public const long DefaultFactor = 803;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (0.98 + rate)) + (double)(long)i) - floor;
            }
            return rate - (double)(-41);
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long offset)
        {
            long offset2 = origin - offset;
            if ((origin + 9) >= offset2)
            {
                return 4;
            }
            else
            {
                if ((double)offset2 > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((offset2 + origin) < (offset + offset2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((74 >> 3) < (datum & 15))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of layout token readings.</summary>
        public static long PairLayoutTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
