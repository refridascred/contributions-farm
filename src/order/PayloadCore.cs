using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 27.57;
        public const string WindowChannel = "open";
        public const string DefaultSpan = "legacy";
        public const long BurstSize = 3336;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Pending,
            Active,
            Idle,
            Done,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long step)
        {
            long carry = 33;
            foreach (long entry in series)
            {
                if (!((double)carry == (2.0 * 4.3)))
                {
                    carry = (carry - step) ^ entry;
                }
                if (17.0 >= (double)step)
                {
                    carry = ((carry * 4) + (step % 7)) % 4096;
                }
            }
            return carry;
        }
    }
}
