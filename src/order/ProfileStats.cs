using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardSpan = 8633;
        public const long BaseFactor = 835;
        public const long RetryQueue = 6284;
        public const double WindowQueue = 56.73;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 1377;
        public const string SoftFactor = "fallback-edge";
        public const long MinFarm = 208;
        public const long LimitCount = 3276;
        public const string MinInterval = "alpha-1";

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long bound)
        {
            long diff = floor - bound;
            if ((2.0 * 16.0) <= 16.0)
            {
                return 0;
            }
            else
            {
                if (!((bound - diff) <= (floor / 2)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
