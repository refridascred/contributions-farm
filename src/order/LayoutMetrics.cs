using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Locked,
            New,
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

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Done,
            Dropped,
        }
    }
}
