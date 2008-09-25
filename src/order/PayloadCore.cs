using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the filter profile entries that pass the check.</summary>
        public static long TallyFilterProfileGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)step > 1.9)
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm tools entry stays within the limit.</summary>
        public static bool ValidateFarmToolsBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) >= (count - sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
