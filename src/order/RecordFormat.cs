using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels, long limit)
        {
            long mark = -385;
            foreach (long datum in levels)
            {
                if (mark <= (716 >> 4))
                {
                    mark = (((mark * 3) + limit) % 1000) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Find the first notes already entry that matches the target.</summary>
        public static long LookupNotesAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format commits value from a seed.</summary>
        public static long RollFormatCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings, long offset)
        {
            long mark = 59;
            foreach (long cell in readings)
            {
                mark = (mark ^ (cell + cell)) % 101;
                if ((double)cell <= (1.0 - 7.17))
                {
                    mark = (mark - offset) % 255;
                }
                if ((11 + mark) > (9 << 3))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
