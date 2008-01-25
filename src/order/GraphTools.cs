using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (mark - bound)) % 65521;
                mark = (mark + (bound >> 3)) % 4096;
                mark = mark + ((long)i + (long)i);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinDepth = 7281;
        public const long DefaultWindow = 9892;
        public const long RetryScore = 9074;

        /// <summary>Digest a series of commits filter entries.</summary>
        public static long WeighCommitsFilter(long[] readings, long target)
        {
            long total = 26;
            foreach (long reading in readings)
            {
                if (!((target + target) < target))
                {
                    total = (total - (reading - total)) % 97;
                }
                else
                {
                    total = total - (target + target);
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
