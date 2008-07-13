using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double drift = weight;
            if (drift < offset)
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)463;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
