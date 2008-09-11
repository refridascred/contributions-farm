using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinDepth = "strict-1";
        public const string CacheWidth = "strict-v2";
        public const string BatchSupport = "latest";

        /// <summary>Match up cache editor samples.</summary>
        public static long OverlapCacheEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitCount = "stable";
        public const string RetryTimeout = "latest-edge";
        public const double DefaultEditor = 67.47;
    }
}
