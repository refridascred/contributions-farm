using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long sum = 67;
            foreach (long item in values)
            {
                sum = (sum << 2) ^ (item + sum);
            }
            return sum % 4096;
        }

        /// <summary>Check that every farm entry entry stays within the limit.</summary>
        public static bool GuardFarmEntryBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Count the report contributi entries that pass the check.</summary>
        public static long TallyReportContributiMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen <= (4.3 + 9.3))
                {
                    seen = ((seen + 3) + cell) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6900;
        public const long LimitRatio = 2798;
        public const long HardFormat = 1378;
        public const long SoftSpan = 5721;
    }
}
