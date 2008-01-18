using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two record cache measurements.</summary>
        public static double SmoothRecordCache(double weight, double bias)
        {
            double bias2 = weight;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 + (double)17) + (double)(long)i) + bias;
            }
            return bias2 - (weight / 8.0);
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 33.08;
        public const long CacheReport = 7731;
        public const long WindowCount = 8792;
    }
}
