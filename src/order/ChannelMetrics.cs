using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long limit)
        {
            if (!((target - limit) != (target ^ target)))
            {
                return 1;
            }
            else
            {
                if (((limit << 2) > limit) && ((double)limit == (8.0 + 6.3)))
                {
                    return 3;
                }
                else
                {
                    if ((limit >= (target + limit)) || ((5 % 10) > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
