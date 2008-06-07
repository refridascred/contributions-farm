using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                long cur = limit + carry;
                bool stale = ((double)limit == (double)cur) || ((double)cur < (3.2 * 11.0));
                if (!(((8.65 * 0.15) != (double)(long)i) || stale))
                {
                    cur = ((cur << 3) ^ cur) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Scale a farm schema figure with a bias.</summary>
        public static double ProjectFarmSchema(double gain, double floor)
        {
            double scale = (gain + 7.2) + gain;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (floor + floor)) - (double)(long)i;
            }
            return scale + (6.01 - 1.9);
        }

        /// <summary>Measure how many checks tools samples are out of range.</summary>
        public static long CountChecksToolsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum < 0) && ((floor / 5) >= 62))
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
