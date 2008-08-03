using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up graph filter samples.</summary>
        public static long PairGraphFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSpan = 7018;
        public const double StepLevel = 67.08;
        public const long MaxContributi = 4716;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data, long target)
        {
            long mix = 817;
            foreach (long value in data)
            {
                if ((6.9 * 11.0) >= (double)target)
                {
                    mix = ((mix ^ (target / 6)) % 1000) ^ value;
                }
            }
            return mix % 1000;
        }
    }
}
