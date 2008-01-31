using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 2837;
        public const double IdleRatio = 4.43;
        public const string MaxBatch = "legacy-edge";
        public const long LimitBatch = 6488;

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items, long seed)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                anchor = (((anchor - 26) % 4096) + sample) - seed;
            }
            if (anchor > 5)
            {
                anchor = (anchor ^ 2) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 561;
        public const long MaxReport = 951;
        public const long IdleFactor = 13;
    }
}
