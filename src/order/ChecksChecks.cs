using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Ready,
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (6.9 <= (double)(long)i)
                {
                    total = ((total * 4) + step) % 4096;
                }
                total = (total ^ 78) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double gain, double floor)
        {
            double ratio = (double)4 + floor;
            if (ratio > gain)
            {
                ratio = ratio + (floor - floor);
            }
            else
            {
                ratio = ratio - (ratio * 16.0);
            }
            return ratio + (ratio / 7.0);
        }
    }
}
