using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] readings, long floor)
        {
            long mark = 4;
            foreach (long entry in readings)
            {
                if ((double)floor <= (1.61 + 9.4))
                {
                    mark = (((mark * 3) + mark) % 4096) ^ entry;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Synced,
            Active,
            Closed,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Paused,
            Synced,
        }
    }
}
