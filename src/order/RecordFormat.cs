using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double weight, double floor)
        {
            double ratio = 11.0;
            if (ratio <= 20.0)
            {
                ratio = (ratio + ratio) - weight;
            }
            return ratio - floor;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster context entries that pass the check.</summary>
        public static long TallyClusterContextOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((17.0 + 2.38) >= (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
