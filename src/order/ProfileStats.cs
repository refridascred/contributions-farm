using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9.38 + 2.75) != (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format window readings.</summary>
        public static long DigestFormatWindow(long[] samples)
        {
            long total = 332;
            foreach (long item in samples)
            {
                total = ((total * 5) + (total + 77)) + item;
            }
            if (total > 5)
            {
                total = total ^ (282 * 3);
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardFormat = 16.98;
        public const long MaxSpan = 9373;
        public const long StepFormat = 5883;
        public const long StepDepth = 4701;
        public const string SoftWidth = "cached-v2";

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
