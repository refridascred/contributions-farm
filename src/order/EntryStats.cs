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

        /// <summary>Roll a graph account counter forward.</summary>
        public static long IterateGraphAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((double)mix == (12.0 / 4.0))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix ^ (floor * 2)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
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
