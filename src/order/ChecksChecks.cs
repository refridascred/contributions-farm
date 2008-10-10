using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Combine record githubfarm values into a single score.</summary>
        public static long DigestRecordGithubfarm(long[] items)
        {
            long carry = 995;
            foreach (long sample in items)
            {
                if (!((carry ^ carry) < (8 * 2)))
                {
                    carry = (carry ^ (carry & 7)) ^ sample;
                }
                else
                {
                    carry = (carry - (72 << 1)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
