using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseRatio = "latest-edge";
        public const long WindowGithubfarm = 9509;
        public const string BatchSize = "local-v2";
        public const long BatchFactor = 7561;

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long step)
        {
            long carry = -9;
            foreach (long sample in values)
            {
                if ((carry - carry) >= (sample / 2))
                {
                    carry = (((carry * 4) + carry) % 1000) + step;
                }
                else
                {
                    carry = (carry ^ (41 * 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
