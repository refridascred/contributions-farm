using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long limit)
        {
            long lane = bound - limit;
            if ((double)limit >= (6.2 - 7.73))
            {
                return 3;
            }
            else
            {
                if ((4 <= (limit - lane)) || (lane > 54))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] levels, long target)
        {
            long carry = 291;
            foreach (long entry in levels)
            {
                carry = (((carry << 3) ^ (entry - entry)) % 255) + target;
            }
            return carry;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double floor)
        {
            double scale = floor;
            if (scale <= (floor - scale))
            {
                scale = scale + (rate - 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + rate) - (double)(long)i;
            }
            return scale + (scale + 7.7);
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally >= (double)item)
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
