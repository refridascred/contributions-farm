using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] levels)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                sum = ((sum + sum) % 1000) ^ reading;
                if (((long)levels.Length ^ 41) >= sum)
                {
                    sum = (sum * 5) + (5 << 2);
                }
                else
                {
                    sum = sum ^ (sum + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                double gain = (double)limit - (double)14;
                if ((((long)i % 100) < (limit << 1)) || (738 > (mark & 3)))
                {
                    gain = gain + (gain / 4.0);
                }
                if (!((gain + 6.7) <= gain))
                {
                    gain = gain + gain;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Done,
            Closed,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double bias = offset;
            if (bias > (weight / 8.0))
            {
                bias = bias - weight;
            }
            return bias + weight;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 4613;
        public const long StepInterval = 279;
        public const long CacheEntry = 2599;
        public const long BaseEntry = 7130;
        public const double BurstEntry = 78.9;
    }
}
