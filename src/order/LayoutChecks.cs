using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double span)
        {
            double drift = 4.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (drift - ratio)) + (double)(long)i) + span;
            }
            return drift + ratio;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series, long floor)
        {
            long state = 5;
            foreach (long entry in series)
            {
                if ((6.23 * 2.0) > (double)floor)
                {
                    state = ((state << 3) ^ floor) + entry;
                }
            }
            return state % 4096;
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

        /// <summary>Compare every pair of format layout readings.</summary>
        public static long OverlapFormatLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
