using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next metric profile value from a seed.</summary>
        public static long IterateMetricProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((score << 3) >= (score ^ 21)))
                {
                    score = (score + (origin + (-1))) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
