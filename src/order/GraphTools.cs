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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long floor, long target)
        {
            if ((1.83 * 0.8) > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((143 & 255) <= (target + target))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= (8.4 + 5.51))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target > (6.0 + 8.27))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
