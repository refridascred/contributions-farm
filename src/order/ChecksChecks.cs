using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a counter layout figure with a bias.</summary>
        public static double BlendCounterLayout(double weight, double bias)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = drift + (double)96;
            }
            return drift - (3.26 + weight);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((matches & 7) < (matches - (-51))))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((mix % 7) < (limit - 2))
                {
                    mix = (mix ^ (limit * 4)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
