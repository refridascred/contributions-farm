using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                mark = ((mark << 2) ^ (mark ^ 99)) ^ item;
            }
            if (mark < 5)
            {
                mark = mark ^ (mark % 3);
            }
            return mark;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public string Region { get; set; } = "";
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
