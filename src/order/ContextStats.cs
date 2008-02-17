using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next buffer cluster value.</summary>
        public static double AdjustBufferCluster(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (double)74) + (double)(long)i) - floor;
            }
            return mean - (mean * 8.7);
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
