using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] items, long limit)
        {
            long result = 62;
            foreach (long item in items)
            {
                result = (result ^ (limit ^ item)) % 255;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1223;
        public const double DefaultSession = 90.05;
        public const double StepFactor = 58.64;

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 4956;
        public const double SoftAccount = 38.01;
        public const long BaseAccount = 2077;
    }
}
