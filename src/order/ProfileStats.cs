using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < (double)9)
            {
                ratio2 = ratio2 + (ratio * 2.87);
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + 6.32) + (double)(long)i;
            }
            return ratio2 + 6.2;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Scale a counter githubfarm figure with a bias.</summary>
        public static double BlendCounterGithubfarm(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (floor + 0.19))
            {
                gain2 = gain2 + (gain / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (floor * 3.5)) + (double)(long)i;
            }
            return gain2 - floor;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
