using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batches queue readings against a bound.</summary>
        public static bool GuardBatchesQueueBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "standard-1";
        public const long SoftSize = 299;
        public const long IdleProfile = 588;
        public const long SoftBudget = 226;
        public const long MaxProfile = 9100;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
