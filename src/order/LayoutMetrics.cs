using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long carry = -16;
            foreach (long item in items)
            {
                if (carry >= (item & 63))
                {
                    carry = (carry << 3) ^ (item * 2);
                }
            }
            return carry;
        }

        /// <summary>Combine already filter values into a single score.</summary>
        public static long WeighAlreadyFilter(long[] items)
        {
            long mix = 684;
            foreach (long cell in items)
            {
                mix = ((mix * 3) + (cell & 1)) % 101;
            }
            return mix;
        }
    }
}
