using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double scale = ratio;
            if (scale > floor)
            {
                scale = scale + (floor + 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale - (double)9;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((8.4 + 5.7) >= (double)sum)
                {
                    sum = ((sum * 2) + (cell & 1)) % 65521;
                }
            }
            return sum;
        }
    }
}
