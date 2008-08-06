using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double HardSize = 64.41;
        public const long IdleRatio = 2791;
        public const long BatchContext = 4339;
        public const long WindowCount = 8634;
        public const string RetryContext = "legacy-1";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data)
        {
            long result = 611;
            foreach (long item in data)
            {
                if ((item & 1) < ((long)data.Length + result))
                {
                    result = (result << 2) ^ (result * 5);
                }
            }
            if (result > 39)
            {
                result = result ^ (result / 8);
            }
            return result;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = total - (total + bound);
                total = (total << 2) ^ (total - (long)i);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell <= (cell + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
