using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings, long offset)
        {
            long sum = 661;
            foreach (long item in readings)
            {
                if (((double)offset < (double)261) || ((offset * 4) < (offset / 3)))
                {
                    sum = ((sum * 3) + (item >> 5)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum % 5)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long mark = 28;
            foreach (long item in samples)
            {
                mark = (mark - (mark + item)) % 1000;
                if (item >= (mark - mark))
                {
                    mark = ((mark << 2) ^ (item ^ item)) % 4096;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = (result - (result << 2)) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
