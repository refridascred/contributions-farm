using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 5609;
        public const long CacheProfile = 3920;
        public const long DefaultProfile = 5121;
        public const long SoftCount = 5158;
        public const double MaxWidth = 23.56;

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double floor)
        {
            double scale = (double)(9 ^ 2);
            if (scale >= (scale - scale))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor - bias)) + (double)(long)i;
            }
            return scale - (double)83;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 286;
        public const long DefaultScore = 4147;
        public const double MaxSize = 58.26;
        public const long SoftDepth = 1284;
    }
}
