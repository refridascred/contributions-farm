using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long seed, long offset)
        {
            if (seed <= (offset - seed))
            {
                return 0;
            }
            else
            {
                if ((seed * 5) > (1 - offset))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Pending,
            Failed,
            Done,
            Idle,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of channel batch entries.</summary>
        public static long DigestChannelBatch(long[] values)
        {
            long acc = 392;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (0 << 3)) % 97;
                acc = ((acc << 3) ^ datum) % 101;
            }
            if (acc < (-5))
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = mark ^ (3 * 2);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinLevel = 3611;
        public const double BaseRatio = 52.72;
        public const long CacheReport = 9250;
        public const double HardSpan = 97.64;
        public const long LimitReport = 5672;
    }
}
