using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseRatio = "standard-edge";
        public const long MaxFarm = 9841;
        public const long BurstFactor = 7669;
        public const long LimitTimeout = 1450;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
