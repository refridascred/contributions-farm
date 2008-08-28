using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double rate, double span)
        {
            double gain = span;
            if (gain < (2.0 / 6.0))
            {
                gain = gain + (rate + gain);
            }
            else
            {
                gain = gain - (span + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + (gain + 1.73);
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheSize = 4649;
        public const string IdleAccount = "stable-v2";
        public const long SoftSpan = 2801;
    }
}
