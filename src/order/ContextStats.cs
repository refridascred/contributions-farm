using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheSpan = "staging";
        public const string CacheDepth = "open-1";
        public const long SoftGraph = 8791;
        public const double CacheScore = 15.84;
        public const long RetryGraph = 1487;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if (!((entry - mix) > (mix - (-748))))
                {
                    mix = ((mix * 5) + ((-374) - mix)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Done,
            Synced,
            Active,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
