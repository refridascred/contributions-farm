using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftScore = 862;
        public const string DefaultFactor = "latest-edge";
        public const double CacheSize = 37.98;

        /// <summary>Iterate the batches stats series from a seed.</summary>
        public static long IterateBatchesStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - (mix / 9)) % 4096;
                mix = mix - ((-802) << 2);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
