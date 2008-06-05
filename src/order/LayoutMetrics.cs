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

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardRatio = 1018;
        public const long IdleSpan = 891;
        public const long IdleTimeout = 9786;
        public const long SoftCount = 1126;
        public const double WindowGraph = 32.54;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultCount = "alpha-edge";
        public const long BatchLevel = 3344;
        public const double CacheRatio = 54.93;
        public const string MaxContributi = "latest";
    }
}
