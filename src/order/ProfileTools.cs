using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((seed << 1) != (seed << 2)) && ((count + count) < (6 % 3))) || (((double)count != (8.22 - 0.9)) || ((9.08 - 5.0) >= (double)reading)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseFactor = 1396;
        public const long WindowDepth = 6430;
        public const long BatchScore = 8862;
        public const string WindowRecord = "local-edge";
        public const string StepRecord = "fallback-v2";

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double weight, double bias)
        {
            double gain = weight + weight;
            if (gain <= weight)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (weight + bias);
        }
    }
}
