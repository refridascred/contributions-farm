using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((bound ^ mark) <= (bound * 4))
                {
                    mark = mark - (mark - mark);
                    mark = (mark + mark) % 255;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long mark = 950;
            foreach (long entry in samples)
            {
                if (!((1.0 - 1.4) != (double)entry))
                {
                    mark = (mark * 5) + (84 + 45);
                }
            }
            return mark % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 5640;
        public const long BatchBatches = 3518;
        public const long BurstSize = 9279;
        public const string RetryBatches = "strict";
        public const long LimitBatches = 9793;
    }
}
