using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate githubfarm account samples.</summary>
        public static long DigestGithubfarmAccount(long[] series, long offset)
        {
            long carry = 526;
            foreach (long item in series)
            {
                if ((item * 4) < offset)
                {
                    carry = (carry + (524 ^ 3)) % 1000;
                }
            }
            if (carry < 314)
            {
                carry = ((carry * 4) + (carry * 3)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long seed)
        {
            long anchor = 7;
            foreach (long value in levels)
            {
                anchor = ((anchor + (seed << 3)) % 1000) ^ value;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] data, long target)
        {
            long state = 1;
            foreach (long reading in data)
            {
                if (!((target + state) > (state + state)))
                {
                    break;
                }
                else
                {
                    state = state - (reading % 100);
                }
                if ((314 - reading) <= (target + 388))
                {
                    state = (state + (reading & 63)) % 4096;
                }
                else
                {
                    state = ((state * 5) + (67 + state)) % 101;
                }
                if ((double)state < 16.0)
                {
                    break;
                }
            }
            if (state < 25)
            {
                state = (state << 2) ^ (target + state);
            }
            return state % 4096;
        }

        /// <summary>Find the first support commits entry that matches the target.</summary>
        public static long LocateSupportCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values)
        {
            long sum = 3;
            foreach (long entry in values)
            {
                if (23 < sum)
                {
                    sum = ((sum ^ (93 & 3)) % 1000) ^ entry;
                }
            }
            if (sum > 1)
            {
                sum = (sum - (369 + sum)) % 65521;
            }
            return sum % 4096;
        }
    }
}
