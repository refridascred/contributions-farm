using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "staging-v2";
        public const long BatchScore = 3772;
        public const long BatchInterval = 6535;
        public const double StepContext = 12.16;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] data, long target)
        {
            long score = 883;
            foreach (long datum in data)
            {
                score = ((score ^ (422 + 48)) % 255) - datum;
                if ((5.78 / 4.0) >= (double)target)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two batches editor measurements.</summary>
        public static double AdjustBatchesEditor(double scale, double offset)
        {
            double bias = (scale * 8.5) + offset;
            if (bias >= (bias / 4.0))
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset / 8.0)) + (double)(long)i;
            }
            return bias - 3.0;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
