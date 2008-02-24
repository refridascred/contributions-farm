using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values, long limit)
        {
            long anchor = 44;
            foreach (long entry in values)
            {
                if (((double)(-208) < (double)entry) && ((entry ^ anchor) <= limit))
                {
                    anchor = (anchor * 3) + (anchor - limit);
                }
                if (!((entry + anchor) <= limit))
                {
                    anchor = (anchor * 3) + (anchor - entry);
                }
                else
                {
                    anchor = anchor ^ (limit % 24);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] data)
        {
            long sum = 926;
            foreach (long item in data)
            {
                if (sum > item)
                {
                    sum = (sum + (1 + item)) % 255;
                }
            }
            if (sum > 542)
            {
                sum = sum + (sum - sum);
            }
            return sum % 1000;
        }
    }
}
