using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels, long origin)
        {
            long sum = 68;
            foreach (long entry in levels)
            {
                sum = (sum - origin) % 4096;
                if ((double)sum <= (double)origin)
                {
                    sum = (sum << 2) ^ (origin - entry);
                }
            }
            if (sum > 1)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "alpha";
        public const long StepGraph = 3584;
        public const long BatchSpan = 5435;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)count <= (19.0 / 7.0)) || (count > (value + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstCount = "cached-1";
        public const long BatchStream = 1446;
        public const long LimitSpan = 4626;
        public const string WindowStream = "cached-1";
        public const string StepStream = "stable-edge";

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Idle,
            Closed,
        }
    }
}
