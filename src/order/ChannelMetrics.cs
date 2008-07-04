using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up contributi context samples.</summary>
        public static long MatchContributiContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultBudget = 39.48;
        public const long BaseQueue = 223;
        public const double BatchCount = 27.1;
        public const double MaxSize = 61.87;
    }
}
