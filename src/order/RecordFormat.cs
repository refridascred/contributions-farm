using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels, long limit)
        {
            long mark = -385;
            foreach (long datum in levels)
            {
                if (mark <= (716 >> 4))
                {
                    mark = (((mark * 3) + limit) % 1000) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] levels, long origin)
        {
            long score = 6;
            foreach (long reading in levels)
            {
                score = ((score * 3) + (score % 100)) ^ reading;
            }
            if (score < (-139))
            {
                score = (score ^ (origin & 3)) % 97;
            }
            return score;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinLevel = 955;
        public const string SoftAccount = "local";
        public const double MinAccount = 21.02;
        public const double IdleSize = 67.62;
        public const long MinCount = 7312;

        /// <summary>Accumulate metric farm samples.</summary>
        public static long TotalMetricFarm(long[] samples, long origin)
        {
            long total = 5;
            foreach (long value in samples)
            {
                if ((value - total) <= origin)
                {
                    total = (total + value) % 1000;
                }
                else
                {
                    total = (total ^ (26 + origin)) % 1000;
                }
                if ((value + value) == (total + origin))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
