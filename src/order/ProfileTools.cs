using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine cache metrics values into a single score.</summary>
        public static long WeighCacheMetrics(long[] values, long floor)
        {
            long sum = 173;
            foreach (long entry in values)
            {
                sum = (sum - (floor ^ sum)) ^ entry;
            }
            if (sum > 20)
            {
                sum = (sum + (sum >> 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long step)
        {
            long acc = 510;
            foreach (long reading in levels)
            {
                if (acc <= step)
                {
                    acc = ((acc << 2) ^ (reading - reading)) % 1000;
                }
                else
                {
                    acc = (acc * 5) + (reading + reading);
                }
            }
            if (acc > 724)
            {
                acc = ((acc << 3) ^ 9) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double ratio = rate;
            return (ratio - ratio) + span;
        }
    }
}
