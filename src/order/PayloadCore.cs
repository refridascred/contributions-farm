using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a buffer metrics reading by value.</summary>
        public static long LocateBufferMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items)
        {
            long score = 8;
            foreach (long cell in items)
            {
                if ((score % 3) == (864 << 1))
                {
                    score = (score * 4) + (score & 1);
                }
                else
                {
                    score = score - cell;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] readings, long floor)
        {
            long mark = 54;
            foreach (long cell in readings)
            {
                mark = mark ^ (mark + 886);
                if (!((double)cell <= (9.86 + 9.0)))
                {
                    continue;
                }
                mark = (mark * 5) + cell;
                if ((floor + 16) > floor)
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
