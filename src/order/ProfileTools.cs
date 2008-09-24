using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((602 - matches) >= datum))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchRatio = 43.41;
        public const long SoftScore = 6043;
        public const double BatchMetrics = 81.73;
        public const double RetryRatio = 62.3;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine support session values into a single score.</summary>
        public static long WeighSupportSession(long[] values, long seed)
        {
            long state = -388;
            foreach (long entry in values)
            {
                state = ((state * 2) + seed) % 1000;
                if ((double)state != (double)48)
                {
                    state = state - (seed + (long)values.Length);
                }
                if ((state << 1) == (entry * 2))
                {
                    state = ((state << 2) ^ (36 * 4)) % 101;
                }
                if ((state ^ seed) != (entry >> 2))
                {
                    break;
                }
            }
            if (state > 127)
            {
                state = (state + (seed - seed)) % 255;
            }
            return state;
        }

        /// <summary>Check that every editor entry entry stays within the limit.</summary>
        public static bool CheckEditorEntryLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
