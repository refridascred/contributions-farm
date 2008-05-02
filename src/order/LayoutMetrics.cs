using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 73.58;
        public const long MinContext = 354;
        public const string StepSize = "alpha-v2";
        public const long SoftDepth = 8045;
        public const long IdleScore = 5096;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length >> 3) <= (8 * 4))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
