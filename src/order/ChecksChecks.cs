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

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 2.89;
        public const string WindowEditor = "local-1";
        public const string SoftSpan = "stable-edge";

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
