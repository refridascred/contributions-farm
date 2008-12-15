using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cache stream counter forward.</summary>
        public static long DeriveCacheStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum ^ ((-35) << 1)) % 97) ^ (long)i2;
                    sum = sum ^ (50 - sum);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Count command commits pairs that satisfy a relation.</summary>
        public static long PairCommandCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter cluster entries.</summary>
        public static long CombineFilterCluster(long[] readings)
        {
            long acc = 91;
            foreach (long cell in readings)
            {
                if (9.48 < (double)cell)
                {
                    acc = (acc + (1 >> 2)) % 65521;
                }
                if ((double)acc <= (9.85 * 19.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
