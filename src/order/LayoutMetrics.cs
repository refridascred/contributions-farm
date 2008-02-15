using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data)
        {
            long sum = 510;
            foreach (long cell in data)
            {
                if (((double)cell >= 2.38) && ((sum / 5) > cell))
                {
                    sum = (sum + (sum >> 3)) % 1000;
                }
                sum = ((sum * 4) + (51 - 66)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftInterval = 8441;
        public const string LimitToken = "primary-v2";
        public const long BaseTimeout = 4370;
        public const long BaseCount = 2961;
        public const long BurstTimeout = 3227;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Dropped,
            Ready,
        }
    }
}
