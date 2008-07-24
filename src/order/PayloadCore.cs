using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double bias, double bias2)
        {
            double ratio = (5.96 + bias2) * 1.66;
            if (ratio <= (bias2 / 4.0))
            {
                ratio = ratio - bias;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Compare every pair of profile cache readings.</summary>
        public static long MatchProfileCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSize = 3686;
        public const long SoftInterval = 484;
        public const long BaseSupport = 979;
        public const string RetryRatio = "strict-1";
        public const long DefaultSupport = 5388;
    }
}
