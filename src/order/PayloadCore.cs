using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double SoftBudget = 54.05;
        public const long BaseWidth = 2460;
        public const string BurstContext = "alpha";

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (acc & 15);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
        }
    }
}
