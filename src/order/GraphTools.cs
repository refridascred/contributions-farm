using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings)
        {
            long mark = 49;
            foreach (long cell in readings)
            {
                if ((cell / 5) != (cell + cell))
                {
                    mark = (mark << 3) ^ cell;
                }
                else
                {
                    mark = (mark + (mark * 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Closed,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data, long seed)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                if ((seed & 127) <= (datum + seed))
                {
                    carry = ((carry * 3) + (carry << 3)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ seed) % 97;
                }
            }
            return carry;
        }
    }
}
