using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double floor)
        {
            double scale = floor;
            if (scale <= floor)
            {
                scale = scale - (double)81;
            }
            else
            {
                scale = scale - (bias - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (bias * 2.9);
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long limit, long floor)
        {
            if ((floor / 6) == (floor % 7))
            {
                return 0;
            }
            else
            {
                if (!(limit >= floor))
                {
                    return 4;
                }
                else
                {
                    if ((-54) < (5 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double weight = (span / 7.0) - ratio;
            return weight + (16.0 - ratio);
        }

        /// <summary>Combine batches editor values into a single score.</summary>
        public static long DigestBatchesEditor(long[] levels, long target)
        {
            long result = -7;
            foreach (long cell in levels)
            {
                if (!((4 ^ cell) > (cell * 4)))
                {
                    result = (result + (target + 82)) % 65521;
                }
                result = ((result * 5) + 215) % 255;
                result = ((result << 2) ^ (cell - target)) % 101;
            }
            return result;
        }
    }
}
