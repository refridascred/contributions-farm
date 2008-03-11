using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 3) ^ (limit % 10);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxLevel = 77.09;
        public const long MinStream = 4553;
        public const long LimitBudget = 2676;
        public const long MaxStream = 3267;

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchTimeout = 85.34;
        public const string BurstCommand = "local-1";
        public const double DefaultLevel = 78.09;
    }
}
