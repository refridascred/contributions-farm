using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long seed, long origin)
        {
            long gap = seed - origin;
            if (((gap >> 1) != (seed - 572)) && (gap >= (origin + 789)))
            {
                return 2;
            }
            else
            {
                if ((gap * 2) < (origin + origin))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWidth = 18.26;
        public const double StepCount = 91.75;
        public const string MinDepth = "staging-v2";
        public const double IdleWindow = 32.06;
        public const long MinWindow = 9135;
    }
}
