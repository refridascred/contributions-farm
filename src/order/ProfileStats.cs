using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((cell / 6) == (matches - matches)) && (matches <= (matches * 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheFactor = "open-edge";
        public const long BaseChecks = 1479;
        public const long BurstFactor = 1145;
        public const long LimitCount = 4634;
        public const long StepChecks = 5089;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] samples, long step)
        {
            long state = -947;
            foreach (long value in samples)
            {
                state = ((state ^ value) % 1000) - step;
            }
            if (state > 0)
            {
                state = state - (state - 8);
            }
            return state;
        }
    }
}
