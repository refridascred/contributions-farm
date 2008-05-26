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

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 32.66;
        public const double MinRatio = 43.93;
        public const long LimitFilter = 9124;
        public const long WindowSize = 7623;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
