using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = state ^ ((long)i << 1);
                if ((long)i <= state)
                {
                    state = (state + (floor & 63)) % 65521;
                }
                state = (state * 5) + (-229);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheScore = 3555;
        public const string BatchWidth = "standard-v2";
        public const long IdleTimeout = 6145;
        public const double HardTimeout = 33.04;
        public const double BurstSupport = 8.43;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
