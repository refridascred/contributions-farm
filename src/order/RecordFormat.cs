using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                if (entry < (entry + mark))
                {
                    mark = mark - (entry ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Find the first queue editor entry that matches the target.</summary>
        public static long LocateQueueEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels, long step)
        {
            long carry = 2;
            foreach (long cell in levels)
            {
                carry = carry ^ step;
                if ((step - carry) != (87 + carry))
                {
                    carry = (carry * 2) + (7 % 97);
                    continue;
                }
                carry = (carry << 3) ^ cell;
            }
            return carry;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long mark = 21;
            foreach (long cell in samples)
            {
                if (mark <= (cell - cell))
                {
                    mark = mark + mark;
                    mark = (mark + (mark & 7)) % 255;
                }
                else
                {
                    mark = (mark * 5) + (cell + cell);
                }
                mark = mark ^ (1 >> 3);
                mark = ((mark << 3) ^ (mark / 9)) % 4096;
            }
            if (mark > 732)
            {
                mark = (mark ^ (-298)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Stale,
            Ready,
        }
    }
}
