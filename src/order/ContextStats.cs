using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 765;
        public const string MaxBudget = "cached-1";
        public const string HardBudget = "standard-edge";
        public const long StepCommand = 7041;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Stale,
            Active,
            Pending,
        }
    }
}
