using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count < (double)step)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardInterval = 23.36;
        public const double IdleBatches = 53.6;
        public const long DefaultBatches = 22;
        public const double BatchSpan = 47.76;

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "strict-edge";
        public const long WindowScore = 8631;
        public const long BurstWindow = 6730;

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data)
        {
            long anchor = 867;
            foreach (long item in data)
            {
                anchor = ((anchor << 3) ^ (item ^ anchor)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many counter batch samples are out of range.</summary>
        public static long TallyCounterBatchMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((seen / 6) > (target + target)) && ((double)seen < (1.93 / 5.0))))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
