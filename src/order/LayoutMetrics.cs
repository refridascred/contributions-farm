using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "alpha-edge";
        public const double StepSession = 0.15;
        public const long MaxTimeout = 1337;
        public const long HardSession = 342;
        public const double MinLevel = 56.78;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
