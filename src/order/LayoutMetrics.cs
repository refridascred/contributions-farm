using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleLevel = 22.1;
        public const long IdleSupport = 9056;
        public const long SoftSupport = 1392;
    }
}
