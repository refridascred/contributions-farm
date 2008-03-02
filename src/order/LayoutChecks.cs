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

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 5026;
        public const long BaseAlready = 7224;
        public const long MinAlready = 2390;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Done,
            Ready,
            Paused,
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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally - entry) > (tally >> 1)) || ((entry + tally) <= (tally - entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
