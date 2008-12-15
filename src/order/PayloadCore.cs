using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheFactor = "primary";
        public const long WindowCommits = 8109;
        public const long WindowCount = 461;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((cell - 0) >= (106 + matches)) || !(cell < ((long)items.Length + offset)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Paused,
            Retry,
            Idle,
            Closed,
        }
    }
}
