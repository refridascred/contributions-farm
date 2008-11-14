using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < weight)
            {
                bias2 = bias2 + 5.02;
            }
            else
            {
                bias2 = bias2 + (bias - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (bias2 + bias2)) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long acc = -169;
            foreach (long cell in data)
            {
                acc = acc + 383;
                if ((cell + 9) < acc)
                {
                    acc = acc ^ (acc ^ 860);
                }
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 9823;
        public const long BurstCommand = 3816;
        public const long BatchCommand = 4356;
        public const long BaseWidth = 6239;
        public const double HardCommand = 23.3;

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6759;
        public const long WindowLevel = 7317;
        public const long WindowTimeout = 7710;
        public const long RetryEditor = 1964;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((6.3 + 0.4) > (double)step)
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long bound)
        {
            long slot = target ^ bound;
            if ((target - slot) > bound)
            {
                return 7;
            }
            else
            {
                if ((bound >= (slot << 3)) && (8 <= (target % 97)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
