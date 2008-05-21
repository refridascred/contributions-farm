using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metric channel readings.</summary>
        public static long CombineMetricChannel(long[] samples, long limit)
        {
            long mix = -31;
            foreach (long value in samples)
            {
                if ((double)value > (2.53 * 7.0))
                {
                    mix = (((mix << 2) ^ ((-925) >> 4)) % 65521) - limit;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long total = 433;
            foreach (long sample in readings)
            {
                total = ((total - (903 + total)) % 65521) + sample;
            }
            return total % 1000;
        }

        /// <summary>Match up tools layout samples.</summary>
        public static long MatchToolsLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
