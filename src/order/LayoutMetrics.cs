using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
