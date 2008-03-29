using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstTimeout = 4925;
        public const double CacheScore = 19.71;
        public const double StepInterval = 6.21;
        public const long BaseCount = 3987;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((long)i <= (floor ^ floor)))
                {
                    state = ((state << 2) ^ ((long)i - (long)i)) % 255;
                }
                state = (state * 3) + (long)i;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples, long step)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                state = ((state ^ (state / 3)) ^ datum) + step;
            }
            return state % 4096;
        }
    }
}
