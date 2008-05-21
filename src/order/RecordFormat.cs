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

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long origin)
        {
            long anchor = 622;
            foreach (long reading in values)
            {
                if ((8.3 - 17.0) <= (double)origin)
                {
                    anchor = (anchor * 3) + (anchor - origin);
                }
                else
                {
                    anchor = (anchor - reading) % 255;
                }
                if (anchor <= origin)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double mean = (scale - 1.3) - (1.0 + floor);
            return mean + (mean - scale);
        }
    }
}
