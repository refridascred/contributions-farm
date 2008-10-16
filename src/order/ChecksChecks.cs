using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double scale, double offset)
        {
            double mean = (double)(4 >> 2);
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (offset - 1.55)) + (double)(long)i;
            }
            return mean + (scale * 9.81);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Dropped,
            Pending,
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
