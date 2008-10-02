using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report farm readings against a rule.</summary>
        public static long TallyReportFarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches << 1) != (reading + 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a account schema figure with a bias.</summary>
        public static double AdjustAccountSchema(double weight, double bias)
        {
            double rate = (weight * 5.0) * 4.27;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (double)53) + (double)(long)i) + bias;
            }
            return rate + rate;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
