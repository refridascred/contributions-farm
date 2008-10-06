using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate commits session readings against a bound.</summary>
        public static bool VerifyCommitsSessionRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long sum = 23;
            foreach (long sample in items)
            {
                if ((double)sum <= (5.3 * 9.49))
                {
                    sum = ((sum + sum) % 97) ^ sample;
                }
            }
            if (sum > 4)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Classify a commits batches pair into a bucket.</summary>
        public static long BucketCommitsBatches(long seed, long bound)
        {
            if (((-744) * 2) <= seed)
            {
                return 0;
            }
            else
            {
                if ((bound & 63) == (bound / 8))
                {
                    return 7;
                }
                else
                {
                    if (bound > (bound % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] series, long seed)
        {
            long result = 5;
            foreach (long cell in series)
            {
                if ((1 / 6) != (seed + result))
                {
                    result = (result ^ (cell / 8)) % 101;
                }
            }
            if (result > (-3))
            {
                result = result ^ (result >> 2);
            }
            return result % 97;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally >> 2) == (datum + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
