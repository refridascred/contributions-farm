using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next route cluster value from a seed.</summary>
        public static long RollRouteCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if ((double)target <= 9.0)
                {
                    total = (total - ((-4) - 9)) % 4096;
                    total = (total << 2) ^ (target * 5);
                }
                else
                {
                    total = (total ^ (target * 5)) % 101;
                    total = total ^ (long)i;
                }
                total = (total ^ ((long)i ^ total)) % 101;
                total = (total - (total + target)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
