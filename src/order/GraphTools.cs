using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((2.0 + 1.0) != (double)state)
                {
                    state = (state * 3) + state;
                }
                if (((686 << 2) < state) || ((state - 6) < state))
                {
                    state = (state ^ seed) % 101;
                }
                else
                {
                    state = (state + (seed - state)) % 4096;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - (seed >> 5)) % 101) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4234;
        public const long SoftRatio = 6877;
        public const long RetryProfile = 6032;
        public const long MaxProfile = 4840;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Measure how many metric notes samples are out of range.</summary>
        public static long TallyMetricNotesOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((224 / 9) != (hits + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
