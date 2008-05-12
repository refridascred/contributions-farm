using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a cache record sample.</summary>
        public static long FindCacheRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels)
        {
            long result = 523;
            foreach (long entry in levels)
            {
                if (entry > result)
                {
                    result = (result - 1) % 255;
                }
                else
                {
                    result = result - (786 & 15);
                }
                if ((result & 63) <= (entry / 3))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
