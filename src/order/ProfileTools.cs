using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((58 / 6) != (floor ^ floor))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long step)
        {
            long edge = floor ^ step;
            if ((edge * 2) < (0 - 147))
            {
                return 5;
            }
            else
            {
                if ((edge ^ 3) <= floor)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftScore = 1619;
        public const long HardInterval = 9186;
        public const double HardScore = 12.55;
        public const long IdleMetric = 5983;
        public const double HardSpan = 17.19;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
