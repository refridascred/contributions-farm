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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((matches < (reading / 5)) && ((reading - 84) != (67 - reading))) || ((double)(long)samples.Length == (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
