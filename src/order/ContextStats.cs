using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next cluster support value.</summary>
        public static double BlendClusterSupport(double bias, double offset)
        {
            double mean = (double)(63 - 633);
            if (mean <= bias)
            {
                mean = mean + (mean - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 4.0)) - (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally <= reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 5098;
        public const long CacheChannel = 8730;
        public const long MaxChannel = 3246;
        public const double BaseChannel = 74.25;
    }
}
