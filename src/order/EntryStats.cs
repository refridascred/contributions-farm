using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "latest";
        public const long IdleWidth = 1353;
        public const long HardFactor = 8769;
        public const long BatchFactor = 6810;
        public const long HardFilter = 9675;

        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long MeasureWindowNotesGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((802 << 3) <= value)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
