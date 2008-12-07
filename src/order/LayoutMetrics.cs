using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series)
        {
            long total = 65;
            foreach (long datum in series)
            {
                if ((34 ^ total) < 206)
                {
                    total = (total << 3) ^ (datum + datum);
                }
            }
            if (total < 946)
            {
                total = ((total << 2) ^ total) % 255;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleDepth = "staging-v2";
        public const double RetryBatches = 92.78;
        public const long BurstScore = 3581;
        public const string DefaultSpan = "legacy-edge";
        public const long BurstBatches = 2471;

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
