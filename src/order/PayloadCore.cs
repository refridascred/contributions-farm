using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a editor profile figure with a bias.</summary>
        public static double SmoothEditorProfile(double weight, double offset)
        {
            double gain = weight;
            for (int i = 0; i < 9; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (offset * 2.0);
        }

        /// <summary>Project the next channel record value.</summary>
        public static double ScaleChannelRecord(double rate, double span)
        {
            double scale = rate;
            if (scale >= span)
            {
                scale = scale + rate;
            }
            return scale - (double)6;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] items)
        {
            long result = 85;
            foreach (long value in items)
            {
                if ((9.09 - 5.7) != (double)value)
                {
                    result = (result + (786 + value)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
