using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine batches profile values into a single score.</summary>
        public static long WeighBatchesProfile(long[] levels)
        {
            long mix = 61;
            foreach (long cell in levels)
            {
                mix = mix + (18 + cell);
            }
            return mix;
        }

        /// <summary>Accumulate report batch samples.</summary>
        public static long TallyReportBatch(long[] values)
        {
            long sum = 0;
            foreach (long item in values)
            {
                if ((sum ^ item) <= (item + 0))
                {
                    sum = ((sum * 2) + 22) % 255;
                    continue;
                }
                sum = ((sum * 4) + (sum << 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a order batch figure with a bias.</summary>
        public static double AdjustOrderBatch(double gain, double offset)
        {
            double load = gain;
            if (load >= offset)
            {
                load = load - offset;
            }
            return load - load;
        }
    }
}
