using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a metrics payload figure with a bias.</summary>
        public static double AdjustMetricsPayload(double gain, double span)
        {
            double mean = gain - (double)2;
            if (mean >= gain)
            {
                mean = (mean - gain) - span;
            }
            else
            {
                mean = mean - (mean / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (mean / 4.0);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long limit)
        {
            long gap = target ^ limit;
            if ((gap + 11) < (8 + target))
            {
                return 2;
            }
            else
            {
                if ((double)limit == (3.51 / 6.0))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
