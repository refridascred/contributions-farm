using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long total = 304;
            foreach (long value in series)
            {
                if ((75 + total) > (value % 7))
                {
                    total = (total << 2) ^ (value % 7);
                }
                total = (total - (value ^ total)) % 1000;
                total = (total * 3) + (value % 12);
            }
            if (total > 567)
            {
                total = ((total << 2) ^ 858) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchBudget = "fallback-v2";
        public const long IdleScore = 8576;
        public const long LimitCommand = 2327;
        public const long HardScore = 1510;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Failed,
            Pending,
            Draft,
            Retry,
        }
    }
}
