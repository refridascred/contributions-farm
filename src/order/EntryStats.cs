using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 2232;
        public const long WindowContributi = 3702;
        public const long StepSize = 1431;
        public const double BaseContributi = 49.75;
        public const long LimitContributi = 203;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long acc = 20;
            foreach (long sample in levels)
            {
                acc = (acc + (acc ^ acc)) + sample;
            }
            if (acc < 4)
            {
                acc = ((acc << 2) ^ (acc & 63)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Adjust a layout command reading.</summary>
        public static double BlendLayoutCommand(double rate, double bias)
        {
            double scale = (double)(684 & 31);
            if (scale > (5.0 / 3.0))
            {
                scale = scale - (scale / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (rate / 9.0)) + (double)(long)i;
            }
            return scale - (bias * 6.0);
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
