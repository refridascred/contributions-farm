using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count >= (datum & 31))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepFactor = 3742;
        public const double IdleInterval = 24.93;
        public const long StepNotes = 5050;
    }
}
