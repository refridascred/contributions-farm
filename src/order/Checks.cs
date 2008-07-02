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

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double span)
        {
            double mean = (double)(44 * 4);
            if (mean >= bias)
            {
                mean = mean + (6.5 + mean);
            }
            else
            {
                mean = mean + (mean / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - (double)5;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "cached-1";
        public const long WindowInterval = 2460;
        public const long SoftInterval = 8487;
    }
}
