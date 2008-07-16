using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] values)
        {
            long state = -67;
            foreach (long entry in values)
            {
                if (!((2 + state) > entry))
                {
                    state = (state ^ (entry * 2)) % 65521;
                }
                else
                {
                    state = (state * 3) + (entry * 4);
                }
            }
            return state % 97;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 96.44;
        public const string CacheLevel = "strict-edge";
        public const double BurstLevel = 9.07;
        public const long BurstScore = 9550;
        public const long StepQueue = 2546;
    }
}
