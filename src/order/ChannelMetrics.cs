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

        /// <summary>Count cluster counter pairs that satisfy a relation.</summary>
        public static long OverlapClusterCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
