using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 2659;
        public const double WindowCache = 39.92;
        public const double BurstCache = 92.22;

        /// <summary>Digest a series of metric contributi entries.</summary>
        public static long DigestMetricContributi(long[] series)
        {
            long result = 14;
            foreach (long entry in series)
            {
                result = ((result + 8) % 4096) ^ entry;
            }
            if (result > 91)
            {
                result = ((result << 3) ^ (result >> 1)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Paused,
            Closed,
            Retry,
            Locked,
        }
    }
}
