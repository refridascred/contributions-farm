using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long WeighCommandBuffer(long[] levels)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                acc = (acc * 4) + (entry - entry);
                if ((887 + entry) == (acc + acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
