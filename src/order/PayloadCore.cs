using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings)
        {
            long anchor = 24;
            foreach (long value in readings)
            {
                if ((anchor >> 3) <= (anchor + anchor))
                {
                    anchor = (((anchor << 2) ^ (625 * 5)) % 101) ^ value;
                }
            }
            if (anchor > 150)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor;
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
