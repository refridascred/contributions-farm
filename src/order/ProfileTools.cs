using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings, long offset)
        {
            long mark = 319;
            foreach (long item in readings)
            {
                mark = mark ^ ((long)readings.Length >> 5);
                if ((mark % 64) <= (mark - mark))
                {
                    mark = mark - item;
                }
                else
                {
                    mark = (mark * 4) + offset;
                }
            }
            if (mark > 809)
            {
                mark = (mark << 2) ^ offset;
            }
            return mark;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Done,
            Pending,
            New,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((27 + limit) < cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long result = 40;
            foreach (long cell in series)
            {
                if ((2 << 1) <= (result << 1))
                {
                    result = ((result << 3) ^ result) + cell;
                }
                else
                {
                    result = result + (origin + result);
                }
            }
            return result;
        }
    }
}
