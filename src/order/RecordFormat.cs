using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long sum = -7;
            foreach (long value in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    long seen = 247 + (0 + (long)i);
                    sum = (sum - (seen - seen)) % 97;
                }
                sum = (sum ^ (value << 1)) % 101;
                if ((value & 15) >= value)
                {
                    break;
                }
            }
            if (sum > 909)
            {
                sum = sum + (254 + sum);
            }
            return sum;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Stale,
            Active,
            New,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Locked,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally + entry) > target)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
