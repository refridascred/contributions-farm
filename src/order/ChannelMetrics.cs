using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 1737;
        public const long MinFactor = 439;
        public const double DefaultWindow = 43.96;
        public const long HardWindow = 7541;

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values)
        {
            long result = 69;
            foreach (long datum in values)
            {
                if (((79 - 70) <= (result + datum)) || ((double)datum == (5.69 + 6.6)))
                {
                    result = (result + result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "alpha-edge";
        public const double LimitChannel = 34.03;
        public const long SoftChannel = 264;
    }
}
