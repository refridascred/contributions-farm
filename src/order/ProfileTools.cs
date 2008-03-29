using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long seed, long step)
        {
            if (((step * 3) > (859 + seed)) && ((step - 0) == (589 >> 2)))
            {
                return 1;
            }
            else
            {
                if (915 <= (1 ^ step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two farm cluster measurements.</summary>
        public static double ProjectFarmCluster(double rate, double bias)
        {
            double weight = 7.31 / 9.0;
            if (weight >= (weight * 19.0))
            {
                weight = (weight - bias) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (bias / 2.0)) + (double)(long)i;
            }
            return weight - (double)722;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 8587;
        public const long CacheFactor = 1702;
        public const string RetryFormat = "fallback-edge";
        public const long MaxDepth = 8196;
        public const long StepFormat = 5039;
    }
}
