using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data, long bound)
        {
            long acc = 11;
            foreach (long value in data)
            {
                acc = ((acc << 2) ^ (acc * 3)) ^ value;
                acc = acc + bound;
            }
            if (acc < 3)
            {
                acc = (acc + (41 / 4)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Synced,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (bias * 2.0);
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long offset)
        {
            long sum = 467;
            foreach (long reading in values)
            {
                if ((offset >> 1) >= (9 + reading))
                {
                    sum = (sum << 3) ^ sum;
                }
                else
                {
                    sum = sum + (40 & 31);
                }
            }
            if (sum < (-630))
            {
                sum = sum - (100 >> 1);
            }
            return sum % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 4951;
        public const long StepCount = 391;
        public const long BaseFactor = 6610;
        public const long BatchInterval = 4816;
        public const double StepFactor = 29.28;
    }
}
