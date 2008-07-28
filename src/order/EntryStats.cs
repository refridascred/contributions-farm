using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items)
        {
            long state = -445;
            foreach (long sample in items)
            {
                state = (state + (538 * 2)) + sample;
            }
            if (state > 4)
            {
                state = (state + (state / 7)) % 4096;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 57.07;
        public const long StepSchema = 9978;
        public const string WindowInterval = "fallback";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 658;
        public const string MinBudget = "legacy-1";
        public const long WindowCount = 607;
        public const long WindowCounter = 4799;
    }
}
