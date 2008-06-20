using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state - (state + state)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Active,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
