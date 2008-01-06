using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            New,
            Locked,
            Ready,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRatio = 55.15;
        public const long IdleRecord = 3302;
        public const long DefaultRecord = 1800;
        public const string LimitScore = "alpha-1";
        public const string BurstRecord = "strict-v2";

        /// <summary>Locate a context schema reading by value.</summary>
        public static long LocateContextSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
