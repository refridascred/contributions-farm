using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Digest a series of format graph entries.</summary>
        public static long DigestFormatGraph(long[] readings)
        {
            long acc = 19;
            foreach (long entry in readings)
            {
                if (((entry >> 4) < (entry + 0)) && ((1.1 + 17.0) != (double)acc))
                {
                    acc = ((acc * 3) + 86) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items, long origin)
        {
            long sum = 826;
            foreach (long item in items)
            {
                if ((sum ^ item) == (item - origin))
                {
                    sum = (sum - (origin ^ sum)) % 4096;
                }
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum - 3) % 97) ^ (long)i;
                }
                sum = (sum ^ (origin - item)) % 255;
            }
            if (sum < 58)
            {
                sum = (sum - 9) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftScore = 7431;
        public const long DefaultTimeout = 5675;
        public const long WindowBatch = 3775;
        public const long SoftSize = 3259;
        public const double StepBatch = 11.43;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
