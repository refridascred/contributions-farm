using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleDepth = "strict";
        public const long WindowWidth = 6901;
        public const string BatchBuffer = "strict-v2";

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long limit)
        {
            if ((double)origin == (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit + limit) >= limit)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxTimeout = 5;
        public const double StepStream = 8.41;
        public const double BaseStream = 16.21;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long seed)
        {
            long result = 42;
            foreach (long reading in values)
            {
                if ((115 + reading) != (result % 7))
                {
                    result = (result + ((long)values.Length + 492)) % 1000;
                }
                else
                {
                    result = (result << 2) ^ (seed & 63);
                }
                if ((6.52 / 9.0) != (double)result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
