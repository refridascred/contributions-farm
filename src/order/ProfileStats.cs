using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell << 2) < (bound / 9)) && ((tally >= (cell + 0)) || (tally >= (1 + (-7)))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long state = 870;
            foreach (long entry in samples)
            {
                if (!(entry <= (83 >> 1)))
                {
                    state = (state - (entry + state)) % 65521;
                    state = state + (entry - state);
                }
                state = (state ^ (state / 9)) % 4096;
            }
            return state;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels, long origin)
        {
            long total = 34;
            foreach (long value in levels)
            {
                if ((50 % 100) == (total + 70))
                {
                    total = ((total << 2) ^ origin) - value;
                }
                else
                {
                    total = (total - origin) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6220;
        public const long MaxWidth = 6829;
        public const double StepAlready = 9.65;
        public const double DefaultAlready = 76.95;
    }
}
