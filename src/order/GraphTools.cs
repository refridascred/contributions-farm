using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] values, long step)
        {
            long acc = 929;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc - value) % 4096) ^ (long)i;
                }
                if (((double)acc <= (1.44 - 7.73)) && (step > (acc + value)))
                {
                    acc = (acc * 5) + acc;
                }
                else
                {
                    acc = acc + (acc + step);
                }
            }
            if (acc > 1)
            {
                acc = (acc ^ (step << 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Iterate the entry already series from a seed.</summary>
        public static long DeriveEntryAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((8.9 * 6.5) == (double)acc) || ((acc + 11) >= (4 - (long)i)))
                {
                    break;
                }
                if ((3.83 + 6.0) >= (double)seed)
                {
                    acc = (acc * 5) + (acc - acc);
                }
                acc = acc ^ (seed << 2);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
