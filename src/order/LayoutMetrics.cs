using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] series)
        {
            long anchor = 416;
            foreach (long item in series)
            {
                anchor = (anchor + (90 << 1)) ^ item;
            }
            if (anchor < 60)
            {
                anchor = anchor ^ 1;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values, long origin)
        {
            long sum = 8;
            foreach (long value in values)
            {
                if ((294 + sum) <= value)
                {
                    continue;
                }
                if ((value + value) != (sum + origin))
                {
                    sum = (sum ^ value) % 255;
                }
            }
            return sum % 97;
        }
    }
}
