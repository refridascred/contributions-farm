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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                long edge = (732 / 5) + (carry + carry);
                edge = ((edge * 5) + ((long)i % 64)) % 4096;
                if ((edge + (long)i) != (edge - floor))
                {
                    carry = (carry << 2) ^ (390 >> 3);
                }
                else
                {
                    edge = edge + (floor << 1);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
