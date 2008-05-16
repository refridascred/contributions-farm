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

        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long TallyLayoutChecksGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - value) == (count / 6))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
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
