using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((5.11 / 5.0) != (double)limit)
                {
                    sum = (sum ^ (sum + 3)) % 1000;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
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
