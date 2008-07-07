using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 426;
        public const string BatchBudget = "local-1";
        public const long LimitQueue = 5971;
        public const long BurstQueue = 8207;
        public const double HardQueue = 47.24;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first layout payload entry that matches the target.</summary>
        public static long LocateLayoutPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
