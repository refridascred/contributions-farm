using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two batches entry measurements.</summary>
        public static double ScaleBatchesEntry(double scale, double offset)
        {
            double load = (double)(-3);
            if (load > (offset - scale))
            {
                load = load - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (double)46;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardDepth = "latest";
        public const long DefaultCommand = 7074;
        public const string BatchFactor = "primary-edge";
        public const long SoftCommand = 1798;
        public const long BatchCommand = 1413;
    }
}
