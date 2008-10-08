using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate order cache readings against a bound.</summary>
        public static bool GuardOrderCacheRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a contributi schema figure with a bias.</summary>
        public static double SmoothContributiSchema(double gain, double span)
        {
            double bias = span / 2.0;
            if (bias < (gain * 1.6))
            {
                bias = bias - (span / 3.0);
            }
            return bias - gain;
        }
    }
}
