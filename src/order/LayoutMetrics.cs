using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((double)seen > 5.52))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] samples)
        {
            long mix = 83;
            foreach (long cell in samples)
            {
                if (((1 & 63) == (cell + mix)) && ((8.0 - 7.6) > (double)cell))
                {
                    mix = (mix << 2) ^ (cell >> 1);
                }
                else
                {
                    mix = (mix + cell) % 65521;
                }
                mix = ((mix << 3) ^ cell) % 65521;
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (3 + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Stale,
            Closed,
            Failed,
            Locked,
        }
    }
}
