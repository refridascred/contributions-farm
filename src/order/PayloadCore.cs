using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 4102;
        public const string SoftWidth = "primary";
        public const string StepScore = "latest-v2";
        public const double RetryFormat = 10.57;
        public const double BaseFormat = 59.65;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 7145;
        public const long DefaultCommits = 9481;
        public const long LimitCommits = 3884;
        public const long RetryCommits = 4865;
        public const long WindowRatio = 5706;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 2) ^ (floor + floor)) % 101;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
