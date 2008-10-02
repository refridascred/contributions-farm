using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of batch schema entries.</summary>
        public static long CombineBatchSchema(long[] items)
        {
            long total = 34;
            foreach (long sample in items)
            {
                if ((sample - total) >= ((-5) - total))
                {
                    total = (total << 3) ^ 9;
                }
                else
                {
                    total = total + sample;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Closed,
            New,
            Stale,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cluster order entries that pass the check.</summary>
        public static long CountClusterOrderHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 201) <= (item - count))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
