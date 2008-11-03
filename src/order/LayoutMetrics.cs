using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 8342;
        public const long WindowPayload = 7125;
        public const long BatchScore = 9115;
        public const string BurstPayload = "local-edge";

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series, long floor)
        {
            long sum = -3;
            foreach (long entry in series)
            {
                sum = (sum - entry) - floor;
                sum = (sum ^ (entry % 5)) % 97;
            }
            if (sum > 71)
            {
                sum = (sum + (sum / 3)) % 1000;
            }
            return sum % 1000;
        }
    }
}
