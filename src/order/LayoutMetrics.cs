using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data, long seed)
        {
            long mix = 435;
            foreach (long entry in data)
            {
                if ((double)mix != (1.9 - 7.2))
                {
                    mix = ((mix ^ (mix + entry)) % 65521) - seed;
                }
            }
            return mix;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
