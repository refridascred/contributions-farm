using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxTimeout = 6689;
        public const double MaxCounter = 2.61;
        public const double BatchCounter = 25.02;
        public const long BurstScore = 4652;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long target)
        {
            if (!(3 >= (step >> 2)))
            {
                return 7;
            }
            else
            {
                if ((double)target > (4.49 / 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((step % 16) > (89 % 16))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target << 1) < target) || ((target + target) >= step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Active,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Synced,
            Ready,
            Paused,
            Stale,
        }
    }
}
