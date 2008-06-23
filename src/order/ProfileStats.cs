using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many batches report samples are out of range.</summary>
        public static long MeasureBatchesReportHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double scale, double floor)
        {
            double bias = floor;
            if (bias >= (double)2)
            {
                bias = bias + (6.57 * 14.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((10.0 * 4.0) < (double)entry) && ((offset << 3) != (long)readings.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
