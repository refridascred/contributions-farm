using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a channel cluster reading.</summary>
        public static double ScaleChannelCluster(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = scale2 + (double)(-217);
            }
            else
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (offset - scale2)) - (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count >= (origin / 9))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Done,
            New,
            Idle,
        }

        /// <summary>Measure how many layout entry samples are out of range.</summary>
        public static long AuditLayoutEntryOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((double)(long)values.Length < (double)item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long WeighContributiStats(long[] levels, long offset)
        {
            long sum = 91;
            foreach (long entry in levels)
            {
                if (!((sum + offset) != (entry + (long)levels.Length)))
                {
                    sum = ((sum * 2) + (9 + sum)) % 65521;
                }
            }
            if (sum < 95)
            {
                sum = sum + (sum - sum);
            }
            return sum % 65521;
        }
    }
}
