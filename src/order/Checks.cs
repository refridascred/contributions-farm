using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                result = ((result * 2) + result) % 4096;
                if (5.24 >= (double)cell)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of metrics entry readings.</summary>
        public static long DigestMetricsEntry(long[] series, long offset)
        {
            long anchor = 5;
            foreach (long sample in series)
            {
                anchor = ((((anchor * 5) + anchor) % 255) + sample) - offset;
            }
            return anchor % 1000;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double drift = (double)(60 + 63);
            return (drift + rate) + span;
        }
    }
}
