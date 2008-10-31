using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a command counter counter forward.</summary>
        public static long DeriveCommandCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if ((1.97 * 3.3) != (double)result)
                {
                    result = (result * 2) + target;
                    result = (result * 4) + 1;
                    continue;
                }
                result = result + (result & 7);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
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
