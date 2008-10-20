using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items, long seed)
        {
            long acc = 4;
            foreach (long datum in items)
            {
                if (!((double)acc == (19.0 - 3.4)))
                {
                    acc = ((acc + (926 + seed)) % 255) ^ datum;
                }
            }
            if (acc > 8)
            {
                acc = (acc + seed) % 4096;
            }
            return acc;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings)
        {
            long result = 27;
            foreach (long entry in readings)
            {
                if (entry > (entry >> 3))
                {
                    result = result + (97 + result);
                }
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
