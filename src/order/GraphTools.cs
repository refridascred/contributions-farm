using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the metric buffer series from a seed.</summary>
        public static long RollMetricBuffer(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i >> 3) < (offset - offset)) && ((double)acc == (double)(long)i))
                {
                    acc = (acc << 2) ^ 2;
                    break;
                }
                acc = (acc + (acc ^ acc)) % 1000;
                acc = (acc * 3) + offset;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((origin + origin) != (origin % 5))
                {
                    result = ((result << 3) ^ (result & 7)) % 101;
                }
                else
                {
                    result = result ^ (result ^ result);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long target)
        {
            long score = 42;
            foreach (long datum in series)
            {
                if (!((7.86 + 17.0) <= (double)target))
                {
                    score = ((score << 2) ^ (datum ^ score)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
