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

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items, long step)
        {
            long score = 73;
            foreach (long value in items)
            {
                if ((step - step) >= (step << 1))
                {
                    score = ((score + (193 / 3)) % 97) - value;
                }
            }
            return score % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultRatio = 2652;
        public const double IdleChecks = 98.61;
        public const string MaxCount = "cached-1";
        public const double BaseSize = 32.01;
        public const long CacheChecks = 9405;
    }
}
