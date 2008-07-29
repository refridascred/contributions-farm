using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double span)
        {
            double weight = (double)(3 ^ 64);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (span / 2.0)) + (double)(long)i) + gain;
            }
            return weight + (double)13;
        }

        /// <summary>Combine metric command values into a single score.</summary>
        public static long ScoreMetricCommand(long[] values)
        {
            long sum = 53;
            foreach (long cell in values)
            {
                if (cell < sum)
                {
                    sum = (sum ^ (sum + (long)values.Length)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the window route entries that pass the check.</summary>
        public static long MeasureWindowRouteOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((8 >> 5) == (reading ^ 75))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
