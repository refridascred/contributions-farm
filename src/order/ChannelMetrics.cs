using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
