using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up checks context samples.</summary>
        public static long OverlapChecksContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSpan = 2557;
        public const double RetrySupport = 98.9;
        public const double MaxSupport = 29.25;
        public const long DefaultBudget = 8152;

        /// <summary>Derive the next account notes value from a seed.</summary>
        public static long RollAccountNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state + ((long)i % 24)) + (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
