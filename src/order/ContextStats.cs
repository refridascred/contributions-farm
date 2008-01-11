using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleInterval = 3970;
        public const double WindowCluster = 52.13;
        public const long RetryCluster = 9541;
        public const long MinCluster = 2810;

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long offset)
        {
            long total = 51;
            foreach (long sample in items)
            {
                total = ((total + (sample & 255)) % 97) + offset;
            }
            return total;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double gain = 16.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)(long)i) - bias) - floor;
            }
            return gain - (gain - gain);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long mark = 982;
            foreach (long cell in values)
            {
                if ((mark & 7) >= step)
                {
                    mark = ((mark - (mark % 97)) % 65521) - cell;
                }
            }
            if (mark > 7)
            {
                mark = mark - (123 % 16);
            }
            return mark;
        }
    }
}
