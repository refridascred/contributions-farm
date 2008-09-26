using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Dropped,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double gain2 = 7.76 + (gain - span);
            if (gain2 > span)
            {
                gain2 = gain2 + (gain / 9.0);
            }
            else
            {
                gain2 = gain2 - (gain2 - gain);
            }
            return gain2 + (5.64 * 20.0);
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (total + (limit / 9)) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
