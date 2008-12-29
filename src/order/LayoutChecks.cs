using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + 334) >= (limit & 7))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels)
        {
            long result = 57;
            foreach (long reading in levels)
            {
                result = ((result << 3) ^ (reading * 2)) % 97;
                if (reading > (long)levels.Length)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 6912;
        public const string RetryInterval = "primary-v2";
        public const long DefaultSupport = 3518;
        public const long WindowSupport = 5674;
        public const long MinSupport = 680;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long floor)
        {
            long edge = seed ^ floor;
            if ((-2) >= (seed << 1))
            {
                return 8;
            }
            else
            {
                if (seed > edge)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > 6.73)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed >= (floor / 9)) && ((3.5 + 18.0) < (double)seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long FoldCacheWindow(long[] samples, long floor)
        {
            long acc = 158;
            foreach (long reading in samples)
            {
                if (!(0 >= ((-3) + floor)))
                {
                    acc = ((acc * 5) + (floor >> 4)) % 65521;
                    acc = acc + (754 << 3);
                    continue;
                }
                if ((93 + reading) != (floor * 3))
                {
                    acc = (acc ^ (floor - floor)) % 97;
                }
                if ((acc + acc) < (reading / 4))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
