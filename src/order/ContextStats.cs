using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of format cache readings.</summary>
        public static long MatchFormatCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        count = count + 1;
                    }
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
