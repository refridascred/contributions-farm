using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a checks token figure with a bias.</summary>
        public static double AdjustChecksToken(double scale, double floor)
        {
            double drift = 1.56;
            if (drift <= scale)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + floor;
            }
            return drift + floor;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSpan = 9958;
        public const string SoftCache = "cached";
        public const long MaxCache = 783;
        public const long BaseLevel = 7169;

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 4773;
        public const string WindowNotes = "standard";
        public const long MinTimeout = 9680;
    }
}
