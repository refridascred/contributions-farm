using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of channel metric readings.</summary>
        public static long FoldChannelMetric(long[] data, long offset)
        {
            long mix = 133;
            foreach (long datum in data)
            {
                if (!((datum + mix) < offset))
                {
                    mix = (mix - 446) % 1000;
                }
                else
                {
                    mix = (mix - (datum - datum)) % 4096;
                }
                mix = mix + offset;
            }
            return mix;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two schema batch measurements.</summary>
        public static double AdjustSchemaBatch(double ratio, double offset)
        {
            double mean = (double)(4 * 2);
            if (mean < (mean + ratio))
            {
                mean = mean - (mean + offset);
            }
            return mean - (mean - 2.0);
        }
    }
}
