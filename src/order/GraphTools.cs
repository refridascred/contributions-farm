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

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples, long floor)
        {
            long mark = 529;
            foreach (long datum in samples)
            {
                if ((mark < ((long)samples.Length % 12)) && ((mark >> 1) <= (datum & 7)))
                {
                    mark = (((mark << 3) ^ (long)samples.Length) % 97) + floor;
                }
            }
            return mark;
        }
    }
}
