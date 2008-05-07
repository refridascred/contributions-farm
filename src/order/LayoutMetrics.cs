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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor ^ (anchor - 674)) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
