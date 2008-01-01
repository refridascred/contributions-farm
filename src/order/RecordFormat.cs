using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((seed + cell) < (195 & 15)) && (17.0 >= (double)seed)) && ((hits & 63) < (cell - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings)
        {
            long mix = 29;
            foreach (long cell in readings)
            {
                mix = (mix ^ (mix ^ mix)) % 255;
                if (((7.0 * 5.08) != (double)mix) || (cell < (cell + cell)))
                {
                    mix = ((mix * 5) + (cell << 3)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((sum + sum) > (offset + sum)))
                {
                    sum = sum - (long)i;
                    continue;
                }
                else
                {
                    sum = (sum ^ (-70)) % 101;
                    sum = ((sum * 5) + ((-33) + sum)) % 65521;
                }
                if (offset >= (612 - offset))
                {
                    sum = ((sum * 4) + (sum & 1)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (offset - sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
