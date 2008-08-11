using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchDepth = 6.48;
        public const long LimitGraph = 8138;
        public const long SoftGraph = 9247;

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
