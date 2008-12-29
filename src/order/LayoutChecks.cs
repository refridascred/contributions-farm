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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen <= (seen ^ 725))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
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
