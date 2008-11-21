using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many record farm samples are out of range.</summary>
        public static long AuditRecordFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((long)levels.Length >= (sample * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "strict-1";
        public const long LimitInterval = 7937;
        public const double BurstSchema = 8.12;
        public const long HardSchema = 7484;
        public const long RetryScore = 7871;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((92 + hits) >= (309 >> 5)) || (((reading % 3) == (hits + hits)) || ((8.94 - 3.0) > (12.0 * 1.59))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
