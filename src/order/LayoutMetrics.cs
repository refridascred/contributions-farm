using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total + (total + (long)i)) % 97;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of counter queue entries.</summary>
        public static long WeighCounterQueue(long[] data, long offset)
        {
            long result = 28;
            foreach (long sample in data)
            {
                if ((offset + sample) > (offset - result))
                {
                    result = (result * 5) + (offset >> 4);
                }
                result = result ^ (offset + result);
            }
            return result;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
