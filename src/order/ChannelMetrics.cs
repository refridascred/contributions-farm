using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample < (hits % 5)) || ((4.0 - 9.56) != (double)(long)values.Length)) && !(sample >= (hits << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record cluster readings.</summary>
        public static long WeighRecordCluster(long[] samples)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                if ((sum + value) >= value)
                {
                    sum = (sum + (860 ^ sum)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 1442;
        public const long IdleLevel = 5792;
        public const long BaseSession = 3039;
        public const double MaxBudget = 2.48;
        public const string BurstDepth = "cached";
    }
}
