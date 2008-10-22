using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long origin)
        {
            if (((-645) - limit) <= limit)
            {
                return 2;
            }
            else
            {
                if ((origin / 9) > limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long TallyToolsSchema(long[] series)
        {
            long mark = 431;
            foreach (long datum in series)
            {
                if ((mark < (mark >> 3)) && ((9.1 - 2.1) > (double)mark))
                {
                    mark = (mark ^ (datum + mark)) % 65521;
                }
            }
            if (mark < 29)
            {
                mark = mark + mark;
            }
            return mark % 1000;
        }

        /// <summary>Locate a session notes reading by value.</summary>
        public static long LookupSessionNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
