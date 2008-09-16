using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next account notes value.</summary>
        public static double AdjustAccountNotes(double ratio, double offset)
        {
            double mean = (ratio * 13.0) * 2.19;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (offset / 2.0)) - (double)(long)i;
            }
            return mean + (double)(-527);
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 62.17;
        public const double BurstRatio = 55.13;
        public const long CacheDepth = 8019;
        public const long MinAccount = 9756;
        public const long BurstAccount = 9087;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Ready,
            Idle,
            Failed,
            Retry,
        }
    }
}
