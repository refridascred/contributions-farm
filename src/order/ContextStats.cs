using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of checks queue readings.</summary>
        public static long FoldChecksQueue(long[] data)
        {
            long acc = 73;
            foreach (long sample in data)
            {
                if ((0.6 * 7.0) != (double)sample)
                {
                    acc = ((acc << 3) ^ acc) % 4096;
                }
                else
                {
                    acc = (acc - (acc + 946)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepBudget = 2173;
        public const long CacheSize = 2617;
        public const long CachePayload = 1857;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
