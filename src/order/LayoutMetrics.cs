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

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double gain, double span)
        {
            double gain2 = span;
            if (gain2 <= (span - gain2))
            {
                gain2 = (gain2 - (double)4) + gain;
            }
            return gain2 + span;
        }
    }
}
