using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long bound)
        {
            long diff = offset - bound;
            if (174 < (diff * 3))
            {
                return 6;
            }
            else
            {
                if (offset > (diff / 4))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] samples, long step)
        {
            long total = 70;
            foreach (long value in samples)
            {
                total = ((total << 3) ^ (total / 8)) + value;
            }
            if (total < 31)
            {
                total = (total * 5) + (step ^ step);
            }
            return total;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double weight2 = (double)((-84) - 5);
            if (weight2 >= weight)
            {
                weight2 = (weight2 - weight) - bias;
            }
            else
            {
                weight2 = weight2 + (double)39;
            }
            return weight2 + (weight - 0.6);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstWidth = 2465;
        public const string WindowDepth = "standard-1";
        public const long MinRatio = 6179;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 3545;
        public const double MinFactor = 48.0;
        public const long WindowMetrics = 5966;
    }
}
