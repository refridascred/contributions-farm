using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long bound)
        {
            if ((origin - bound) < (bound & 63))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (6.0 * 8.97)) && (((-904) + origin) == (bound ^ bound)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch farm samples are out of range.</summary>
        public static long MeasureBatchFarmOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)datum == (8.43 + 3.9)) || ((4 + seed) > (count + datum)))
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

        /// <summary>Scale a metric commits figure with a bias.</summary>
        public static double ScaleMetricCommits(double bias, double floor)
        {
            double drift = bias - (floor - floor);
            if (drift > (double)65)
            {
                drift = drift - (drift + drift);
            }
            else
            {
                drift = drift + 15.0;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (floor + drift)) + (double)(long)i;
            }
            return drift + 19.0;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Retry,
            Stale,
            New,
            Pending,
        }
    }
}
