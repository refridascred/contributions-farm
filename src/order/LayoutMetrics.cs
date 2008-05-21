using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a batch payload counter forward.</summary>
        public static long DeriveBatchPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                if (((double)anchor > (5.0 - 6.0)) || ((anchor * 5) < step))
                {
                    anchor = (anchor ^ (650 << 3)) % 65521;
                }
                else
                {
                    anchor = (anchor + (53 >> 3)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
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
