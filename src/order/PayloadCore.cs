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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits <= (datum ^ datum)) && ((double)hits > (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
