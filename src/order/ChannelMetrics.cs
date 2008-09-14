using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long origin)
        {
            long diff = offset - origin;
            if ((diff - diff) >= (3 + offset))
            {
                return 3;
            }
            else
            {
                if ((offset + origin) <= (diff * 5))
                {
                    return 4;
                }
                else
                {
                    if ((origin + 50) <= (offset & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 4033;
        public const long SoftSpan = 3000;
        public const long MinBatches = 1669;
    }
}
