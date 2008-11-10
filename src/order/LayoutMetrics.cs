using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 6911;
        public const long BurstScore = 5666;
        public const long IdleGraph = 3409;
        public const long MaxGraph = 2557;
        public const long MaxTimeout = 9325;

        /// <summary>Locate a farm order reading by value.</summary>
        public static long LookupFarmOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
