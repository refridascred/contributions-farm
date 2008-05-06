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

        /// <summary>Digest a series of channel report entries.</summary>
        public static long DigestChannelReport(long[] samples)
        {
            long total = 0;
            foreach (long sample in samples)
            {
                if ((1.9 + 7.51) >= (double)sample)
                {
                    total = total ^ sample;
                }
                if ((long)samples.Length >= (total + 128))
                {
                    break;
                }
            }
            if (total < 54)
            {
                total = total - (total / 9);
            }
            return total;
        }
    }
}
