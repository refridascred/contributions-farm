using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double ratio2 = ratio / 4.0;
            if (ratio2 > (double)52)
            {
                ratio2 = ratio2 + (offset / 9.0);
            }
            return ratio2 + ratio2;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double drift = floor;
            return (drift - (floor * 4.4)) + gain;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((reading & 255) < reading) && ((count + reading) != (count >> 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
