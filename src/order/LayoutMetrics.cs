using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a notes payload pair into a bucket.</summary>
        public static long GradeNotesPayload(long limit, long target)
        {
            if ((6.0 / 3.0) != (double)limit)
            {
                return 3;
            }
            else
            {
                if ((target << 1) >= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 15) <= (target ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long state = 67;
            foreach (long sample in items)
            {
                state = state - (sample ^ sample);
                if ((8.31 * 4.78) <= (double)state)
                {
                    state = ((state * 2) + (sample - state)) % 101;
                }
            }
            return state % 65521;
        }
    }
}
