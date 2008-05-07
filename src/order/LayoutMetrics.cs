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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count >= target)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
