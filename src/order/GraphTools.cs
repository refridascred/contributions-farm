using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cluster entry readings.</summary>
        public static long CombineClusterEntry(long[] series)
        {
            long sum = 50;
            foreach (long item in series)
            {
                sum = sum - (7 - sum);
                sum = (sum ^ (item / 4)) % 65521;
                sum = (sum ^ (sum & 63)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples)
        {
            long total = 82;
            foreach (long entry in samples)
            {
                total = total - (entry + 822);
                if ((entry + total) < (entry % 3))
                {
                    total = total - entry;
                }
            }
            if (total < (-465))
            {
                total = total - total;
            }
            return total % 1000;
        }
    }
}
