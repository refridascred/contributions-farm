using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long BucketCounterLayout(long limit, long step)
        {
            long next = limit + step;
            if (step <= next)
            {
                return 3;
            }
            else
            {
                if (step <= (limit << 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] data)
        {
            long result = 958;
            foreach (long datum in data)
            {
                result = ((result + result) % 1000) + datum;
                result = (result + (result & 255)) % 1000;
            }
            if (result > 39)
            {
                result = (result << 3) ^ ((-474) << 2);
            }
            return result % 65521;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items)
        {
            long anchor = 5;
            foreach (long item in items)
            {
                anchor = ((anchor + anchor) % 65521) + item;
            }
            if (anchor < 33)
            {
                anchor = (anchor << 2) ^ (anchor + 6);
            }
            return anchor % 1000;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double drift = bias * 5.8;
            if (drift <= weight)
            {
                drift = drift - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
