using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches >= (entry - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state - state) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSize = "fallback";
        public const long CacheFarm = 6806;
        public const long SoftSize = 4060;
        public const long DefaultFarm = 5077;
        public const long BatchBudget = 8989;
    }
}
