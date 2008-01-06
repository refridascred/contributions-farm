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

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 8984;
        public const long IdleSession = 3414;
        public const long RetrySession = 678;
        public const long CacheLevel = 4606;

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
