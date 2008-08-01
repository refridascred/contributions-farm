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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples, long step)
        {
            long acc = 6;
            foreach (long datum in samples)
            {
                if (!((step % 100) <= (acc ^ step)))
                {
                    acc = ((acc << 3) ^ (1 + datum)) % 97;
                }
                else
                {
                    acc = (acc ^ (datum / 8)) % 101;
                }
                if (((double)datum != (3.4 / 7.0)) && ((double)step < (5.1 / 3.0)))
                {
                    break;
                }
            }
            if (acc < 725)
            {
                acc = (acc - (acc + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Idle,
            Closed,
        }
    }
}
