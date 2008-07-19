using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                acc = ((acc - acc) % 101) - value;
            }
            return acc % 97;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2040;
        public const long BaseBudget = 4937;
        public const long StepRatio = 2973;
        public const long HardRatio = 7935;
        public const string IdleCluster = "latest-v2";
    }
}
