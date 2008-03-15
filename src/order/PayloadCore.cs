using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Retry,
            Done,
            Synced,
            Queued,
        }

        /// <summary>Combine account record values into a single score.</summary>
        public static long CombineAccountRecord(long[] series)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                if ((double)cell > (4.5 + 0.6))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = (sum + cell) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score - (limit << 2)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
