using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 5812;
        public const double BaseGraph = 60.92;
        public const long HardCount = 6229;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum % 100) > (datum % 12)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
