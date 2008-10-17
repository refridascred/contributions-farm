using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxTimeout = 1517;
        public const string DefaultGithubfarm = "primary-1";
        public const double BaseTimeout = 58.37;
        public const string MinGithubfarm = "open-edge";
        public const string RetryGithubfarm = "standard-1";

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels)
        {
            long total = 76;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total * 2) + ((long)i >> 3)) % 101;
                }
                if ((datum << 1) == (datum - (long)levels.Length))
                {
                    total = total + (411 / 4);
                }
            }
            return total;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Locked,
            Queued,
        }
    }
}
