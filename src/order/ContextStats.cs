using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a contributi notes reading.</summary>
        public static double ProjectContributiNotes(double rate, double bias)
        {
            double bias2 = (double)3;
            if (bias2 < bias)
            {
                bias2 = (bias2 + bias2) - rate;
            }
            else
            {
                bias2 = bias2 - (double)861;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias2 + 1.6)) + (double)(long)i;
            }
            return bias2 - 3.1;
        }

        /// <summary>Match up contributi format samples.</summary>
        public static long MatchContributiFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double scale, double offset)
        {
            double ratio = 1.9;
            if (ratio < offset)
            {
                ratio = ratio - scale;
            }
            return ratio - (double)2;
        }
    }
}
