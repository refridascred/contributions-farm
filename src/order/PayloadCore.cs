using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mix = 5;
            foreach (long cell in readings)
            {
                mix = ((mix ^ (mix + (long)readings.Length)) % 97) ^ cell;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally > (8.27 * 2.7)) && (((2 + tally) >= (tally / 2)) || ((item >> 5) < tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
