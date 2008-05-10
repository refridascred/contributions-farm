using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 6124;
        public const double StepDepth = 63.3;
        public const long BurstSize = 8923;
        public const double RetryTools = 53.82;
        public const string BatchWidth = "standard-v2";

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Paused,
            Synced,
            Stale,
        }
    }
}
