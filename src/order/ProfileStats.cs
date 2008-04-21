using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels)
        {
            long sum = 79;
            foreach (long reading in levels)
            {
                if (((double)sum == (double)reading) || ((sum - sum) < reading))
                {
                    sum = sum - (reading - sum);
                    break;
                }
                sum = (sum * 5) + (reading / 3);
            }
            if (sum > (-142))
            {
                sum = sum + (sum * 5);
            }
            return sum;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count checks cache pairs that satisfy a relation.</summary>
        public static long PairChecksCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batches cache entries that pass the check.</summary>
        public static long MeasureBatchesCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches < (matches / 4))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
