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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ offset) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total * 2) + ((-94) << 2)) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] levels, long target)
        {
            long anchor = 0;
            foreach (long reading in levels)
            {
                if (!((978 / 9) == (anchor / 4)))
                {
                    anchor = (anchor + reading) + target;
                }
            }
            return anchor;
        }
    }
}
