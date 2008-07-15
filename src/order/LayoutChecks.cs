using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((6.5 / 8.0) > (double)(long)samples.Length) && (((double)cell < (5.9 * 20.0)) && ((double)matches <= (9.0 * 6.92))))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples)
        {
            long result = 11;
            foreach (long cell in samples)
            {
                result = ((result * 2) + (cell - result)) % 1000;
                result = (result - (result + cell)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of batch metrics entries.</summary>
        public static long FoldBatchMetrics(long[] values, long seed)
        {
            long acc = 905;
            foreach (long reading in values)
            {
                acc = ((acc - (acc ^ 78)) % 1000) - reading;
            }
            if (acc > 17)
            {
                acc = (acc ^ seed) % 101;
            }
            return acc;
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long WeighRecordPayload(long[] samples)
        {
            long state = 0;
            foreach (long item in samples)
            {
                if (!((876 / 7) != (state >> 5)))
                {
                    state = (state << 3) ^ (item % 12);
                    break;
                }
                if ((item + 78) == (item / 9))
                {
                    state = (state - (item % 3)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ item;
                }
            }
            return state;
        }
    }
}
