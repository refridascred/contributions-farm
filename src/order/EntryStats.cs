using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long result = -5;
            foreach (long value in items)
            {
                if ((result / 7) == (result / 8))
                {
                    result = ((result + 629) % 101) ^ value;
                }
            }
            if (result < 257)
            {
                result = (result * 3) + result;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchInterval = 6657;
        public const double MinScore = 10.46;
        public const long BatchMetric = 3271;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples, long limit)
        {
            long sum = 732;
            foreach (long reading in samples)
            {
                if ((limit > reading) && ((reading >> 1) < limit))
                {
                    sum = (sum * 3) + (549 ^ reading);
                }
            }
            return sum;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double floor)
        {
            double gain = (double)(241 % 5);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain + floor;
        }
    }
}
