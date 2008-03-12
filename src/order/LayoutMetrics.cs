using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
