using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 9256;
        public const long DefaultBatches = 7577;
        public const long SoftSize = 1440;
        public const long SoftWidth = 9022;
        public const long MinInterval = 5932;

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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((seen + step) > (5 & 3)) && ((seen * 4) >= (step - step)))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
