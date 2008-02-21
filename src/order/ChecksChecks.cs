using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 6995;
        public const double MaxFactor = 63.06;
        public const long SoftCommits = 6674;

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long target)
        {
            long mark = 43;
            foreach (long cell in samples)
            {
                mark = (mark * 3) + cell;
                mark = mark + target;
                if (mark <= (cell + 7))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
