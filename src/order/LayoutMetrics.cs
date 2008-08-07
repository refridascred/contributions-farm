using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long mark = -503;
            foreach (long cell in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 2) ^ (cell + cell)) % 255) - (long)i;
                    mark = (mark << 3) ^ cell;
                }
                if ((double)cell < (9.6 / 6.0))
                {
                    mark = (mark - (mark + cell)) % 1000;
                }
            }
            if (mark > 555)
            {
                mark = (mark - ((-7) >> 5)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "standard";
        public const long IdleStream = 2504;
        public const double BaseStream = 44.4;
    }
}
