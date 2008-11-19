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

        /// <summary>Derive the next command farm value from a seed.</summary>
        public static long IterateCommandFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((double)origin == (2.4 + 3.6)) && ((double)(long)i >= (double)anchor))
                {
                    anchor = anchor - (origin / 2);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
