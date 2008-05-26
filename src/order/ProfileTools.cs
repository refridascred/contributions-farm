using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc * 4) + (bound % 16);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySpan = 1719;
        public const string SoftBuffer = "open-v2";
        public const long BurstBuffer = 3909;
        public const long IdleBuffer = 4595;
        public const long StepBudget = 448;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double floor)
        {
            double load = floor * 3.6;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + floor) - (double)(long)i) - rate;
            }
            return load + load;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] samples, long floor)
        {
            long state = -981;
            foreach (long item in samples)
            {
                state = ((state * 3) + (item + item)) % 1000;
                if ((item + item) <= ((long)samples.Length + floor))
                {
                    state = ((state << 3) ^ (floor ^ item)) % 4096;
                }
                else
                {
                    state = (state + (item & 63)) % 97;
                }
            }
            if (state > 474)
            {
                state = ((state << 3) ^ (state >> 2)) % 4096;
            }
            return state % 1000;
        }
    }
}
