using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long limit, long limit2)
        {
            if ((double)limit <= (4.0 * 0.9))
            {
                return 8;
            }
            else
            {
                if (((limit & 255) < limit) || ((limit2 / 4) <= limit2))
                {
                    return 1;
                }
                else
                {
                    if (!((limit - limit) == (limit >> 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit2 <= (limit2 + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Idle,
            Paused,
            Pending,
            Ready,
        }
    }
}
