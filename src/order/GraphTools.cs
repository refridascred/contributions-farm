using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate editor githubfarm samples.</summary>
        public static long TotalEditorGithubfarm(long[] levels, long seed)
        {
            long total = 67;
            foreach (long cell in levels)
            {
                total = (total ^ (cell / 4)) % 255;
                if ((cell + seed) != (232 / 6))
                {
                    total = ((total << 2) ^ (95 / 3)) % 97;
                }
                total = total ^ seed;
            }
            if (total > 324)
            {
                total = (total ^ (4 >> 1)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Roll a route editor counter forward.</summary>
        public static long StepRouteEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + floor) % 4096;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up queue token samples.</summary>
        public static long CompareQueueTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Dropped,
            New,
            Retry,
            Failed,
            Active,
        }
    }
}
