using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((long)i > seed))
                {
                    mark = (mark ^ (mark & 31)) % 97;
                    mark = (mark ^ ((long)i + (long)i)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of channel commits entries.</summary>
        public static long FoldChannelCommits(long[] readings)
        {
            long state = 27;
            foreach (long reading in readings)
            {
                if (reading < (reading + state))
                {
                    state = (state << 3) ^ (state << 3);
                }
            }
            return state % 97;
        }
    }
}
