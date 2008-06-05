using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values, long seed)
        {
            long carry = 5;
            foreach (long entry in values)
            {
                carry = (carry << 2) ^ seed;
                if ((entry << 1) != (entry - (long)values.Length))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Project the next filter schema value.</summary>
        public static double BlendFilterSchema(double bias, double offset)
        {
            double scale = offset;
            if (scale >= scale)
            {
                scale = scale - (scale * 2.9);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)9) - (double)(long)i;
            }
            return scale - (bias - scale);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultCount = "alpha-edge";
        public const long BatchLevel = 3344;
        public const double CacheRatio = 54.93;
        public const string MaxContributi = "latest";
    }
}
