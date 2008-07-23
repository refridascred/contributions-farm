using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long sum = 64;
            foreach (long value in values)
            {
                if ((0.5 - 2.25) > (double)value)
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                else
                {
                    sum = (sum ^ (value ^ sum)) % 255;
                }
            }
            if (sum > (-512))
            {
                sum = ((sum << 3) ^ (sum / 2)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            New,
            Synced,
            Idle,
            Active,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Dropped,
            Closed,
            Paused,
            Locked,
        }
    }
}
