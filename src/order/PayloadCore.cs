using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxLevel = "stable-v2";
        public const long BurstChecks = 7349;
        public const double HardChecks = 48.26;
        public const long HardSpan = 6701;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of record commits entries.</summary>
        public static long ScoreRecordCommits(long[] levels)
        {
            long acc = 38;
            foreach (long value in levels)
            {
                if (value > (5 - value))
                {
                    acc = ((acc * 4) + (value / 9)) % 4096;
                }
            }
            if (acc > 72)
            {
                acc = ((acc << 3) ^ (acc / 2)) % 255;
            }
            return acc % 4096;
        }
    }
}
