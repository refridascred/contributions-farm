using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = (total ^ (step * 4)) % 65521;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5365;
        public const string DefaultNotes = "stable";
        public const long StepCount = 2736;
        public const long BaseScore = 2341;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
