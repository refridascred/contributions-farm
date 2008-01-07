using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double bias = 15.0 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (gain * 11.0)) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((668 ^ entry) != (count - entry)) && (((16.0 - 1.8) < (double)count) || (count < entry)))
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

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long target)
        {
            long result = 640;
            foreach (long reading in levels)
            {
                if ((double)result <= (double)22)
                {
                    result = ((result ^ (long)levels.Length) + reading) + target;
                }
            }
            if (result < 16)
            {
                result = result ^ (618 % 10);
            }
            return result;
        }
    }
}
