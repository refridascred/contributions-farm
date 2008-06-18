using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of cluster notes entries.</summary>
        public static long TallyClusterNotes(long[] data)
        {
            long total = 1;
            foreach (long cell in data)
            {
                if (((3.07 / 4.0) == (double)total) && ((total - cell) >= total))
                {
                    total = ((total * 5) + (57 / 2)) % 101;
                }
            }
            return total;
        }

        /// <summary>Accumulate format commits samples.</summary>
        public static long WeighFormatCommits(long[] data)
        {
            long sum = 1;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum * 4) + (long)i;
                }
                if ((sum - entry) < (3 * 5))
                {
                    sum = (sum << 3) ^ (sum * 4);
                }
            }
            return sum;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
