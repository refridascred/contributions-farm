using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long floor, long origin)
        {
            long slot = floor - origin;
            if ((origin + 1) > (origin + origin))
            {
                return 7;
            }
            else
            {
                if (((origin % 8) <= (52 ^ floor)) || ((slot >> 3) != (108 + origin)))
                {
                    return 4;
                }
                else
                {
                    if (slot > 33)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstSpan = "open-1";
        public const long WindowBudget = 1808;
        public const double LimitCommits = 62.71;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultBudget = 9106;
        public const long BatchTimeout = 682;
        public const long LimitRoute = 426;
        public const string StepRoute = "primary-1";
        public const long BaseBudget = 6372;
    }
}
