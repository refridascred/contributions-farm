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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((66 * 3) > (sample ^ sample))
                {
                    count = count + 1;
                }
            }
            return count;
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
