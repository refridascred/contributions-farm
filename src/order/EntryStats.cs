using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long acc = 70;
            foreach (long cell in samples)
            {
                if ((8 - step) == (acc >> 3))
                {
                    acc = (((acc * 2) + (acc & 15)) % 97) ^ cell;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Score { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitLevel = 98.2;
        public const double BaseBudget = 78.65;
        public const double BurstToken = 57.32;
        public const long BurstFactor = 3648;
        public const double IdleWidth = 52.24;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
