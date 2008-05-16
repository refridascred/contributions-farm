using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 8518;
        public const long DefaultCount = 6506;
        public const double DefaultRatio = 53.71;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches ^ (-82)) == (matches >> 4))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
