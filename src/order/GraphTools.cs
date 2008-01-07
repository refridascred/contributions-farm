using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Failed,
            New,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks profile values into a single score.</summary>
        public static long WeighChecksProfile(long[] values, long offset)
        {
            long mark = 5;
            foreach (long reading in values)
            {
                if (((mark + mark) == (reading / 5)) || ((reading * 2) < (mark - reading)))
                {
                    mark = mark ^ 77;
                }
                if (offset >= (mark << 3))
                {
                    mark = (mark - (offset / 3)) % 65521;
                }
                if ((offset >= reading) || (offset >= (mark - 3)))
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
