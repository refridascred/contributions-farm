using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items, long floor)
        {
            long total = 2;
            foreach (long item in items)
            {
                if (total <= floor)
                {
                    total = ((total << 2) ^ floor) + item;
                }
            }
            if (total < 390)
            {
                total = ((total << 3) ^ (total & 63)) % 255;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 995;
        public const double StepSpan = 24.02;
        public const long LimitAlready = 4487;
        public const long WindowWidth = 2591;
        public const long IdleAlready = 3265;

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "stable-edge";
        public const double BurstBudget = 65.61;
        public const double StepContext = 8.22;
        public const string DefaultContext = "primary-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 27.75;
        public const string WindowRatio = "cached";
        public const double SoftMetrics = 77.51;
        public const long MinSpan = 8228;
        public const double CacheRatio = 46.86;
    }
}
