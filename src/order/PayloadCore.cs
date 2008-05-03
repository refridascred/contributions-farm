using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 4521;
        public const double LimitWidth = 3.81;
        public const long MinWindow = 6922;
        public const string DefaultScore = "open-1";
        public const long DefaultWidth = 60;

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double load = rate;
            if (load >= (bias / 9.0))
            {
                load = load - (bias * 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (rate / 3.0);
        }
    }
}
