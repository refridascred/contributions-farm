using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values, long origin)
        {
            long sum = 23;
            foreach (long datum in values)
            {
                sum = (((sum * 5) + (datum >> 4)) % 101) - origin;
                sum = (sum - datum) % 101;
                if ((sum % 60) == ((long)values.Length + 326))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double ratio = (double)(1 % 64);
            if (ratio > (double)1)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio + (weight + span);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Check that every report stream entry stays within the limit.</summary>
        public static bool CheckReportStreamRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - (long)i) >= floor)
                {
                    anchor = anchor + ((long)i ^ anchor);
                }
                anchor = anchor - (floor ^ floor);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
