using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double scale = span;
            if (scale <= (double)17)
            {
                scale = (scale - scale) - weight;
            }
            else
            {
                scale = scale + span;
            }
            return scale + (double)5;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Pending,
            Draft,
            Done,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix ^ (long)i) % 1000) ^ (long)i2;
                    mix = mix ^ (35 ^ mix);
                }
                mix = mix - (bound + 8);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((20.0 - 11.0) == (double)seed)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
