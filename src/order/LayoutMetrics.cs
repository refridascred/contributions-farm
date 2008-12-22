using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long step2)
        {
            long gap = step + step2;
            if (((double)step2 == (double)5) || ((6 + step) != (gap << 2)))
            {
                return 7;
            }
            else
            {
                if (((399 + step2) != (step2 + step2)) && ((gap + step) <= step2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Ready,
            New,
        }
    }
}
