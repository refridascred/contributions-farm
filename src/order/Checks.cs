using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples)
        {
            long mark = 786;
            foreach (long cell in samples)
            {
                mark = (mark + (mark + mark)) % 1000;
                mark = mark - mark;
                if ((9.98 - 3.9) != (double)cell)
                {
                    mark = ((mark * 2) + mark) % 255;
                }
                else
                {
                    mark = (mark ^ (cell / 9)) % 97;
                }
                if (((7 & 255) == (cell / 7)) && ((cell + cell) > 8))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (mark + 37)) % 65521;
                mark = ((mark << 3) ^ (offset & 15)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
