using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Combine buffer context values into a single score.</summary>
        public static long WeighBufferContext(long[] levels)
        {
            long state = 2;
            foreach (long item in levels)
            {
                state = (state - (state >> 5)) + item;
            }
            return state;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
