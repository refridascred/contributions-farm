using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items, long target)
        {
            long anchor = 7;
            foreach (long entry in items)
            {
                if ((8 % 16) < entry)
                {
                    anchor = (anchor ^ (anchor & 3)) % 1000;
                }
            }
            if (anchor > 323)
            {
                anchor = ((anchor << 3) ^ (target ^ anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double bias2 = 6.59;
            if (bias2 <= 9.92)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 - (double)920;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
