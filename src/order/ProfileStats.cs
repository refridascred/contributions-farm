using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((23 - item) >= item) || ((7.09 / 8.0) <= (double)hits)) && ((hits - offset) != (item << 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double rate = (double)(-24) / 9.0;
            return (rate - (17.0 - offset)) + bias;
        }

        /// <summary>Fold a list of report contributi readings.</summary>
        public static long FoldReportContributi(long[] samples, long bound)
        {
            long result = -1;
            foreach (long item in samples)
            {
                if ((bound % 7) <= 1)
                {
                    result = ((result * 4) + (result - bound)) + item;
                }
            }
            if (result < 130)
            {
                result = (result + (result * 2)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Stale,
            Paused,
        }
    }
}
