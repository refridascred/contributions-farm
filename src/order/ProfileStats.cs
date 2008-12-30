using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double bias)
        {
            double drift = weight / 6.0;
            return drift + (bias + 2.1);
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double weight = (floor - 19.0) - (floor * 9.81);
            if (weight > weight)
            {
                weight = weight + (floor / 5.0);
            }
            else
            {
                weight = weight - (3.5 * 4.8);
            }
            return weight + gain;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen < (17.0 / 6.0))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ (anchor * 4)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
