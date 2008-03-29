using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long IterateQueueContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double scale = 3.69;
            if (scale > (9.0 / 3.0))
            {
                scale = (scale - (3.79 - 2.6)) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - 5.59) + (double)(long)i;
            }
            return scale + floor;
        }
    }
}
