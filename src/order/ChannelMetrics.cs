using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data)
        {
            long carry = -611;
            foreach (long cell in data)
            {
                carry = (((carry * 5) + 53) % 4096) ^ cell;
            }
            return carry % 97;
        }

        /// <summary>Measure how many checks stream samples are out of range.</summary>
        public static long AuditChecksStreamHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)value != (7.4 + 5.44)) || (((double)value <= (2.87 - 5.43)) || ((double)value == (1.0 - 8.3))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultTimeout = 48.46;
        public const long WindowGithubfarm = 5948;
        public const long SoftGithubfarm = 3054;
        public const string BaseGithubfarm = "fallback";
    }
}
