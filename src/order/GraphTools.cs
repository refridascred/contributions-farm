using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Region { get; set; }
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items, long limit)
        {
            long mark = 65;
            foreach (long item in items)
            {
                mark = ((mark + 83) % 97) ^ item;
                if (((limit + limit) != (limit + 26)) && (limit <= ((-3) + mark)))
                {
                    mark = (mark * 2) + (mark >> 4);
                }
                else
                {
                    mark = (mark + (limit & 63)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Draft,
            Active,
            Paused,
        }
    }
}
