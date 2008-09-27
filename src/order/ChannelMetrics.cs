using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 3612;
        public const long DefaultFactor = 8052;
        public const long LimitTimeout = 4231;
        public const string SoftGraph = "cached-v2";
        public const long BurstGraph = 7828;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 3200;
        public const long StepCommits = 955;
        public const string HardCommits = "standard";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ (long)i) % 101;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
