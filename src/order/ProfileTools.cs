using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples, long bound)
        {
            long sum = 63;
            foreach (long datum in samples)
            {
                sum = (sum + bound) + datum;
                sum = (sum * 3) + (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 661;
            foreach (long datum in samples)
            {
                result = ((result ^ result) % 1000) + datum;
                result = (result ^ (0 << 2)) % 255;
                result = result + (result ^ 4);
            }
            if (result < 47)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((double)item <= (9.0 * 4.0)) && !((bound % 8) <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data, long seed)
        {
            long carry = -746;
            foreach (long item in data)
            {
                carry = (((carry + (12 * 3)) % 97) ^ item) + seed;
            }
            return carry;
        }
    }
}
