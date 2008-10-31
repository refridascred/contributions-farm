using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 8446;
        public const double BatchBudget = 28.3;
        public const long IdleChecks = 7613;
        public const double BaseChecks = 23.55;

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] readings, long target)
        {
            long anchor = 94;
            foreach (long sample in readings)
            {
                if ((sample % 10) >= (target >> 3))
                {
                    anchor = (anchor + (anchor - sample)) % 4096;
                }
                else
                {
                    anchor = anchor ^ (sample & 127);
                }
                if ((target << 1) >= (anchor - (-42)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
