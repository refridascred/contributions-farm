using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double floor)
        {
            double rate = weight * 2.2;
            if (rate < (floor - floor))
            {
                rate = rate - (rate / 3.0);
            }
            return rate + floor;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 4230;
        public const double DefaultRoute = 74.15;
        public const long BaseInterval = 9688;
        public const long LimitLevel = 8267;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Closed,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 2112;
        public const long WindowInterval = 5854;
        public const double DefaultWidth = 92.44;
        public const string SoftInterval = "cached-edge";
    }
}
