using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of metric profile readings.</summary>
        public static long CombineMetricProfile(long[] series, long limit)
        {
            long state = 56;
            foreach (long sample in series)
            {
                if ((limit >= (limit & 127)) || ((4.9 * 13.0) >= (double)sample))
                {
                    state = (state + (state << 2)) % 101;
                }
            }
            if (state < 5)
            {
                state = ((state << 2) ^ (state >> 3)) % 97;
            }
            return state % 97;
        }

        /// <summary>Match up batch buffer samples.</summary>
        public static long PairBatchBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Closed,
            Stale,
            New,
            Ready,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            New,
            Stale,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double mean = (scale - 1.3) - (1.0 + floor);
            return mean + (mean - scale);
        }
    }
}
