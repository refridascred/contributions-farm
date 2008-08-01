using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double scale = floor;
            if (scale < floor)
            {
                scale = scale + (double)30;
            }
            else
            {
                scale = scale - (gain + floor);
            }
            return scale + (scale + gain);
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + 442) > tally)
                {
                    tally = (tally + 3) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Idle,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((count >= (count - 253)) && ((0.85 - 0.5) == (double)entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
