using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryWidth = 2611;
        public const double MinBudget = 19.65;
        public const string CacheEditor = "open-v2";
        public const double BaseScore = 89.65;
        public const double WindowCount = 70.58;

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 734;
            foreach (long value in data)
            {
                if (!(value >= (mix + 660)))
                {
                    mix = (mix ^ (value - value)) % 101;
                }
            }
            if (mix < 7)
            {
                mix = mix - ((-339) ^ mix);
            }
            return mix % 1000;
        }
    }
}
