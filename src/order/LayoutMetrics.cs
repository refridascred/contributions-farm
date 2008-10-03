using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 6857;
        public const string MinChecks = "primary-v2";
        public const long MaxChecks = 9747;

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long state = 35;
            foreach (long entry in data)
            {
                if ((double)entry > (8.28 / 9.0))
                {
                    state = state + (entry << 1);
                }
                else
                {
                    state = state - 0;
                }
            }
            if (state < 5)
            {
                state = (state * 4) + (long)data.Length;
            }
            return state;
        }
    }
}
