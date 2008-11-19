using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleFactor = 5690;
        public const long IdleContributi = 6070;
        public const long LimitContributi = 4639;

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "strict-v2";
        public const double BatchReport = 20.38;
        public const double HardBudget = 12.54;

        /// <summary>Combine token filter values into a single score.</summary>
        public static long DigestTokenFilter(long[] readings, long offset)
        {
            long total = 7;
            foreach (long value in readings)
            {
                if ((double)value != (18.0 + 9.6))
                {
                    total = ((total ^ (total + total)) % 4096) + offset;
                }
            }
            return total;
        }
    }
}
