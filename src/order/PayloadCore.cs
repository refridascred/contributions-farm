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

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long limit)
        {
            long mark = 6;
            foreach (long sample in series)
            {
                if ((9 >> 5) > (mark % 24))
                {
                    mark = ((mark ^ (sample + sample)) % 101) - limit;
                }
            }
            if (mark > (-777))
            {
                mark = mark + (mark / 2);
            }
            return mark % 1000;
        }
    }
}
