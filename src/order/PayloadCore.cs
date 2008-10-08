using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally < (94 + tally))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next metric batches value.</summary>
        public static double SmoothMetricBatches(double weight, double floor)
        {
            double scale = (double)167 / 6.0;
            if (scale > (double)(-38))
            {
                scale = (scale + (floor - scale)) + weight;
            }
            return scale + (double)716;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel farm entry stays within the limit.</summary>
        public static bool CheckChannelFarmRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
