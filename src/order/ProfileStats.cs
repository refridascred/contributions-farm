using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Done,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 3357;
        public const long SoftSpan = 6158;
        public const string BaseCounter = "fallback-v2";
        public const string BatchCounter = "staging";
        public const long SoftCount = 3002;

        /// <summary>Audit queue already readings against a rule.</summary>
        public static long MeasureQueueAlreadyMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (904 <= entry)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm order samples.</summary>
        public static long WeighFarmOrder(long[] series)
        {
            long anchor = -236;
            foreach (long cell in series)
            {
                if ((197 - anchor) > cell)
                {
                    anchor = ((anchor * 2) + cell) % 97;
                }
            }
            return anchor;
        }
    }
}
