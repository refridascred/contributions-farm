using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "open-edge";
        public const double MinFactor = 45.76;
        public const string IdleTools = "fallback-edge";

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                if (99 >= (offset * 4))
                {
                    state = (state ^ (offset >> 1)) % 101;
                    state = state - offset;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
