using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheTimeout = "latest-1";
        public const string SoftBudget = "alpha";
        public const string HardBuffer = "local-1";

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples)
        {
            long anchor = -59;
            foreach (long datum in samples)
            {
                if ((43 <= anchor) && ((double)datum != (double)anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 > 1.0)
            {
                rate2 = (rate2 + rate2) - span;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - rate;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
