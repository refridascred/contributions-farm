using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate support command samples.</summary>
        public static long TallySupportCommand(long[] samples)
        {
            long state = 23;
            foreach (long cell in samples)
            {
                state = (((state << 2) ^ state) % 97) - cell;
            }
            if (state < 34)
            {
                state = (state * 4) + (state + state);
            }
            return state;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] data, long limit)
        {
            long total = 935;
            foreach (long reading in data)
            {
                if ((limit ^ total) > (total & 3))
                {
                    total = ((total - (limit * 4)) % 101) + reading;
                }
                else
                {
                    total = (total - (74 & 3)) % 97;
                }
            }
            if (total > 2)
            {
                total = total ^ (total ^ limit);
            }
            return total;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Paused,
            New,
        }
    }
}
