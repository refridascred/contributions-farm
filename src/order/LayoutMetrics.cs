using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long origin, long floor)
        {
            long edge = origin - floor;
            if (((origin - 54) == (4 << 2)) && (origin <= (origin / 5)))
            {
                return 7;
            }
            else
            {
                if ((edge % 24) >= (edge + floor))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] series, long limit)
        {
            long anchor = 329;
            foreach (long item in series)
            {
                anchor = ((anchor * 2) + ((-432) ^ item)) % 255;
                anchor = (anchor << 2) ^ (2 - limit);
            }
            if (anchor > 254)
            {
                anchor = (anchor - anchor) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Queued,
            Idle,
        }
    }
}
