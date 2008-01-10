using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "local-1";
        public const long StepBatch = 1910;
        public const long BaseCount = 1755;
        public const long MaxInterval = 4916;

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long mark = 23;
            foreach (long reading in data)
            {
                mark = (mark * 4) + (reading * 3);
            }
            if (mark < 25)
            {
                mark = (mark + step) % 255;
            }
            return mark;
        }

        /// <summary>Accumulate queue token samples.</summary>
        public static long WeighQueueToken(long[] samples, long step)
        {
            long total = 50;
            foreach (long value in samples)
            {
                total = (((total * 5) + (total % 5)) - value) - step;
            }
            if (total < 61)
            {
                total = total - total;
            }
            return total % 4096;
        }
    }
}
