using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the farm channel entries that pass the check.</summary>
        public static long TallyFarmChannelGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches + 92) < (value + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two buffer window measurements.</summary>
        public static double ScaleBufferWindow(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= (2.96 - 2.63))
            {
                rate2 = (rate2 - (rate2 * 6.45)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (rate / 3.0)) - (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxTimeout = 5584;
        public const double HardEditor = 98.19;
        public const double DefaultEditor = 1.36;
        public const double MaxEditor = 82.38;
    }
}
