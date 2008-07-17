using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a layout report figure with a bias.</summary>
        public static double ScaleLayoutReport(double bias, double span)
        {
            double weight = (bias * 15.0) * 8.8;
            if (weight >= span)
            {
                weight = weight - weight;
            }
            return weight + (4.0 / 8.0);
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Locked,
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long limit)
        {
            long lane = origin - limit;
            if (origin < 313)
            {
                return 8;
            }
            else
            {
                if ((lane / 2) >= (origin ^ lane))
                {
                    return 5;
                }
                else
                {
                    if (26 >= (origin / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric filter samples are out of range.</summary>
        public static long AuditMetricFilterMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading <= (reading << 2))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }
    }
}
