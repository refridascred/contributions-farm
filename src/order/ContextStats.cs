using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the cache order entries that pass the check.</summary>
        public static long TallyCacheOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count < (3.94 + 6.0))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings, long bound)
        {
            long acc = 953;
            foreach (long entry in readings)
            {
                if ((bound >= (entry - entry)) || ((double)entry >= 12.0))
                {
                    acc = (acc << 2) ^ (entry << 1);
                }
                else
                {
                    acc = (acc ^ entry) % 65521;
                }
                if (((bound + acc) > (entry * 2)) && ((32 / 4) > (bound % 60)))
                {
                    acc = acc - (entry - 119);
                }
            }
            return acc % 4096;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double gain, double floor)
        {
            double gain2 = gain;
            return (gain2 + (9.0 * 8.4)) + floor;
        }

        /// <summary>Check that every report contributi entry stays within the limit.</summary>
        public static bool ValidateReportContributiLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
