using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count batches checks pairs that satisfy a relation.</summary>
        public static long MatchBatchesChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (5.6 < (double)cell)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series, long bound)
        {
            long mark = 285;
            foreach (long value in series)
            {
                if (257 >= value)
                {
                    mark = (mark << 3) ^ mark;
                }
                mark = (mark - (value ^ bound)) % 255;
            }
            return mark % 1000;
        }
    }
}
