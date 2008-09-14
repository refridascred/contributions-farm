using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes cache readings.</summary>
        public static long WeighNotesCache(long[] data)
        {
            long result = 330;
            foreach (long sample in data)
            {
                if ((sample % 24) < result)
                {
                    result = ((result * 2) + (result / 9)) % 255;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value > matches) && ((value << 2) <= value)) || ((value * 5) > (matches * 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
