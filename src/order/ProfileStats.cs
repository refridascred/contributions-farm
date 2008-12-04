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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((0 << 2) == ((long)i % 3))
                {
                    anchor = (anchor ^ (665 - limit)) % 255;
                    anchor = (anchor ^ (560 & 15)) % 65521;
                }
                else
                {
                    anchor = (anchor - (long)i) % 1000;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    long slot = (limit + limit) / 9;
                    anchor = ((anchor ^ (slot ^ anchor)) % 4096) ^ (long)i3;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
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
