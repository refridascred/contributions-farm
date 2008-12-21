using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the payload channel entries that pass the check.</summary>
        public static long TallyPayloadChannelOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < (bound + 46))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            New,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long total = 548;
            foreach (long item in series)
            {
                total = total - (item >> 1);
                total = (total ^ (item + origin)) % 65521;
                if (origin < (total + total))
                {
                    total = (total * 2) + total;
                }
            }
            if (total < 68)
            {
                total = (total + (total / 7)) % 97;
            }
            return total % 4096;
        }
    }
}
