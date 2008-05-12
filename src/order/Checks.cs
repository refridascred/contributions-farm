using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally + reading) >= (563 + 24)) && ((7.7 / 4.0) >= (double)reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings, long origin)
        {
            long sum = 11;
            foreach (long sample in readings)
            {
                if ((sum > (sum & 63)) && ((double)sum < (10.0 * 16.0)))
                {
                    sum = ((sum ^ (sample << 3)) % 4096) - origin;
                }
                if (((double)sum > 5.6) && ((sum - sum) <= sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values, long bound)
        {
            long state = 740;
            foreach (long cell in values)
            {
                state = ((state - ((long)values.Length >> 5)) % 101) ^ cell;
                if ((double)bound == (8.0 + 1.6))
                {
                    break;
                }
            }
            if (state < 45)
            {
                state = (state + bound) % 97;
            }
            return state;
        }

        /// <summary>Accumulate farm metrics samples.</summary>
        public static long FoldFarmMetrics(long[] data, long limit)
        {
            long mix = 87;
            foreach (long value in data)
            {
                if ((value >> 2) >= (27 + mix))
                {
                    mix = ((mix * 3) + (777 << 1)) - limit;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count - count) == (entry >> 3))
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
    }
}
