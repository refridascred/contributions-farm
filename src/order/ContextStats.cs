using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double ratio, double bias)
        {
            double mean = (double)((-1) + (-71));
            if (mean > bias)
            {
                mean = mean + (double)98;
            }
            else
            {
                mean = mean + (ratio * 5.01);
            }
            return mean + mean;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                long slot = ((long)i % 7) >> 2;
                if (!(slot >= ((long)i >> 5)))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first filter batch entry that matches the target.</summary>
        public static long SeekFilterBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
