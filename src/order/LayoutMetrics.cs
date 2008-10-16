using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
        }
    }
}
