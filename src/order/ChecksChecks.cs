using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleBudget = 8227;
        public const double CacheChecks = 68.31;
        public const long HardChecks = 4008;
        public const long StepChecks = 1911;
        public const long BaseSpan = 4795;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items)
        {
            long result = -6;
            foreach (long sample in items)
            {
                result = (result - ((long)items.Length ^ 9)) ^ sample;
            }
            if (result > 5)
            {
                result = result - result;
            }
            return result % 4096;
        }
    }
}
