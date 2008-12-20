using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally % 8) < tally)
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double gain, double span)
        {
            double bias = gain;
            if (bias > (bias - span))
            {
                bias = bias + (span + bias);
            }
            else
            {
                bias = bias + (double)5;
            }
            return bias - (double)23;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
