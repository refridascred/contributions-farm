using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 3) + (floor >> 3);
                mix = mix + mix;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long AuditCacheFormatOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen + seen) < 7)
                {
                    seen = ((seen + 2) - item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double gain, double floor)
        {
            double mean = (double)(3 / 6);
            if (mean < (mean + mean))
            {
                mean = mean + (floor * 15.0);
            }
            else
            {
                mean = mean + (double)(-9);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (gain - mean)) + (double)(long)i;
            }
            return mean + (mean / 8.0);
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Done,
            Ready,
        }
    }
}
