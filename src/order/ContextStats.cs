using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 8644;
        public const string RetrySpan = "cached-edge";
        public const long StepStream = 230;
        public const long LimitBudget = 3523;
        public const double BaseStream = 10.11;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items)
        {
            long result = 2;
            foreach (long datum in items)
            {
                if ((1 << 1) >= datum)
                {
                    result = result ^ (result << 2);
                }
            }
            if (result < 60)
            {
                result = ((result << 2) ^ (result >> 2)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
