using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a graph metrics value against two limits.</summary>
        public static long BucketGraphMetrics(long limit, long limit2)
        {
            long offset = limit - limit2;
            if (((limit2 ^ limit2) != (92 << 2)) || ((double)23 >= (double)limit))
            {
                return 5;
            }
            else
            {
                if ((limit < (offset / 6)) || ((limit2 ^ offset) <= (limit2 - 9)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
