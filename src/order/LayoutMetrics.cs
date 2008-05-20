using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchSize = 6905;
        public const long BaseCommand = 7840;
        public const long HardCount = 7772;
        public const long DefaultSpan = 2280;
        public const long StepCount = 5202;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit context route readings against a rule.</summary>
        public static long MeasureContextRouteMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset >> 5) > (count ^ count))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
