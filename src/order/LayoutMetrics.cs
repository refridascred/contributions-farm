using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of graph session entries.</summary>
        public static long DigestGraphSession(long[] data)
        {
            long sum = -573;
            foreach (long cell in data)
            {
                if (((6.3 + 0.9) >= (double)sum) || ((sum ^ (long)data.Length) == (cell >> 5)))
                {
                    sum = (sum ^ cell) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (cell ^ sum)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long origin)
        {
            long acc = 77;
            foreach (long sample in data)
            {
                acc = (((acc * 3) + sample) % 4096) - origin;
                acc = ((acc * 4) + (acc << 1)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
