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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((mix <= (origin - mix)) || ((double)origin < (1.17 * 3.0)))
                {
                    mix = (mix - (origin % 60)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values)
        {
            long score = 86;
            foreach (long value in values)
            {
                if ((score / 4) > (value + 389))
                {
                    score = ((score << 3) ^ 13) % 65521;
                }
            }
            return score % 97;
        }
    }
}
