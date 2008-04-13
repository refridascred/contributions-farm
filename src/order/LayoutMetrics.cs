using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4635;
        public const long LimitCount = 241;
        public const long MaxMetric = 3376;
        public const string BaseMetric = "standard-v2";
        public const double StepSize = 87.72;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels)
        {
            long mix = -9;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix << 2) ^ entry) ^ (long)i;
                }
                mix = (mix ^ (mix % 2)) % 1000;
                if ((mix + entry) > (entry - 47))
                {
                    mix = (mix ^ (entry + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            New,
            Locked,
            Paused,
        }
    }
}
