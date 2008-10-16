using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Pending,
            Dropped,
            Closed,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double gain, double floor)
        {
            double mean = (floor + floor) / 6.0;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - floor) + (double)(long)i) + gain;
            }
            return mean - (double)(-210);
        }

        /// <summary>Check that every cache metric entry stays within the limit.</summary>
        public static bool GuardCacheMetricRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
