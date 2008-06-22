using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 6502;
        public const double LimitCount = 20.09;
        public const long HardFarm = 3628;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepRatio = 2109;
        public const long IdleTimeout = 7468;
        public const long BurstCounter = 8661;
        public const double StepTimeout = 87.49;
        public const long BaseCounter = 6600;

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "standard-v2";
        public const string BurstTimeout = "primary";
        public const string BatchTimeout = "alpha-v2";
        public const long BatchEditor = 9807;
        public const string WindowBudget = "alpha";

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
