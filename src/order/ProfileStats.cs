using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 < bias)
            {
                bias2 = bias2 + gain;
            }
            else
            {
                bias2 = bias2 + (gain - 9.59);
            }
            return bias2 - (11.0 - bias2);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] samples)
        {
            long mix = -89;
            foreach (long entry in samples)
            {
                if ((65 * 2) > entry)
                {
                    mix = (mix + (long)samples.Length) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (entry / 5)) % 255;
                }
            }
            if (mix > 389)
            {
                mix = (mix - (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Done,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Dropped,
            Closed,
        }
    }
}
