using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((4 >> 5) == (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (7.92 * 3.4)) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
