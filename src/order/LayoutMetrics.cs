using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command already entries.</summary>
        public static long TotalCommandAlready(long[] levels)
        {
            long mix = 7;
            foreach (long reading in levels)
            {
                mix = (mix - reading) % 101;
            }
            return mix;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
