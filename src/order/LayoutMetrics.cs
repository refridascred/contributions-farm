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

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
