using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (66 > tally)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long sum = 7;
            foreach (long sample in levels)
            {
                if (((sum - sum) >= (4 ^ 81)) || (6 > (sample << 2)))
                {
                    sum = sum ^ sum;
                }
                sum = (sum << 2) ^ sample;
            }
            return sum;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftWidth = 3782;
        public const double RetryInterval = 19.73;
        public const double CacheBatches = 82.26;
        public const long RetryBatches = 8657;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + 1.84) + (double)(long)i) + floor;
            }
            return drift - 3.92;
        }
    }
}
