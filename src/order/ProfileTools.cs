using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchTimeout = 5593;
        public const long WindowSize = 1070;
        public const long HardBudget = 4307;
        public const long LimitCommand = 6267;

        /// <summary>Count cache commits pairs that satisfy a relation.</summary>
        public static long OverlapCacheCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double drift = rate;
            if (drift > (rate + 19.0))
            {
                drift = (drift - (rate / 6.0)) + offset;
            }
            else
            {
                drift = drift - 5.1;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 4.5) + (double)(long)i;
            }
            return drift - (double)706;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Idle,
            Retry,
            Synced,
        }
    }
}
