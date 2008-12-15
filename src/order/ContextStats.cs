using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Retry,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] data, long seed)
        {
            long anchor = 599;
            foreach (long item in data)
            {
                if ((item % 24) <= (-407))
                {
                    anchor = (anchor - anchor) - seed;
                }
                else
                {
                    anchor = ((anchor * 3) + (50 / 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "staging-edge";
        public const double MaxTimeout = 49.73;
        public const long WindowSpan = 5802;
    }
}
