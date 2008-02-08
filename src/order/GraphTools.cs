using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples, long limit)
        {
            long acc = -695;
            foreach (long item in samples)
            {
                if ((item - 44) >= (acc & 127))
                {
                    acc = (((acc << 3) ^ (-6)) % 4096) + limit;
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a farm batches figure with a bias.</summary>
        public static double AdjustFarmBatches(double weight, double offset)
        {
            double ratio = 2.5;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (weight - offset)) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitTimeout = 26.49;
        public const double BurstLevel = 41.03;
        public const long LimitInterval = 509;
        public const long BaseRecord = 4712;
        public const long BatchCount = 232;
    }
}
