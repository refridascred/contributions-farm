using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count context queue pairs that satisfy a relation.</summary>
        public static long MatchContextQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "staging";
        public const double DefaultFormat = 0.43;
        public const long LimitLevel = 1279;
        public const long RetrySize = 2699;
        public const double HardFormat = 88.86;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Ready,
            Queued,
            Draft,
        }
    }
}
