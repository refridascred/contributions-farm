using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                carry = carry ^ item;
            }
            if (carry < 31)
            {
                carry = ((carry << 3) ^ (limit - limit)) % 97;
            }
            return carry;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings)
        {
            long state = 16;
            foreach (long reading in readings)
            {
                state = ((state - (9 / 3)) % 255) ^ reading;
            }
            if (state > 67)
            {
                state = (state * 5) + state;
            }
            return state % 97;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 52.12;
        public const long RetryInterval = 9980;
        public const long BurstWidth = 6181;
        public const long BatchStats = 123;
        public const long HardBudget = 8519;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 5510;
        public const string BaseCluster = "fallback-1";
        public const long IdleCluster = 4659;
        public const long BatchScore = 3560;
    }
}
