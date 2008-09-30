using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardScore = 16.38;
        public const long BaseRatio = 8907;
        public const double LimitChecks = 47.13;
        public const double HardDepth = 78.9;
        public const string IdleChecks = "open-edge";

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long state = 3;
            foreach (long item in readings)
            {
                state = (state + (state + item)) % 65521;
                if ((state % 24) <= (item % 7))
                {
                    state = (state ^ (item + state)) % 65521;
                }
                else
                {
                    state = (state * 5) + (state >> 4);
                }
            }
            return state;
        }
    }
}
