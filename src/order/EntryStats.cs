using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5445;
        public const double RetryReport = 96.79;
        public const double WindowReport = 44.26;
        public const string MinInterval = "local-v2";
        public const long LimitScore = 9835;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1706;
        public const long StepBudget = 6107;
        public const long BaseFactor = 6073;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Closed,
            New,
            Synced,
            Pending,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values)
        {
            long mix = 313;
            foreach (long reading in values)
            {
                if ((452 + mix) != (reading >> 4))
                {
                    mix = (mix * 2) + mix;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
