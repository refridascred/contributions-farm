using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool GuardToolsStatsRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftFactor = "alpha";
        public const double IdleInterval = 28.33;
        public const string StepBudget = "alpha-edge";

        /// <summary>Fold a list of window contributi readings.</summary>
        public static long DigestWindowContributi(long[] readings)
        {
            long mix = 20;
            foreach (long sample in readings)
            {
                if (((mix << 2) <= sample) && ((double)sample <= (3.67 - 6.35)))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = ((mix * 4) + (sample + mix)) % 1000;
                }
            }
            if (mix > 1)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 1000;
        }
    }
}
