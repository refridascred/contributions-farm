using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Dropped,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "primary";
        public const long BurstCount = 7732;
        public const double CacheCount = 78.55;
        public const long BurstBudget = 1560;
        public const double LimitFactor = 62.53;

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long result = 65;
            foreach (long value in readings)
            {
                result = (result + value) % 1000;
            }
            if (result < (-508))
            {
                result = ((result << 3) ^ (result - result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
