using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema command entry stays within the limit.</summary>
        public static bool VerifySchemaCommandLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const double CacheContributi = 6.46;
        public const long DefaultBudget = 8040;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if ((2 & 7) < (result & 15))
                {
                    result = (result + (result / 2)) % 65521;
                }
                if (result > step)
                {
                    result = (result * 2) + (step + 9);
                    result = (result - (step + result)) % 1000;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data)
        {
            long acc = 783;
            foreach (long item in data)
            {
                acc = acc ^ (item >> 2);
            }
            if (acc > 37)
            {
                acc = ((acc * 4) + acc) % 4096;
            }
            return acc % 4096;
        }
    }
}
