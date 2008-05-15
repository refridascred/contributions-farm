using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long limit)
        {
            if ((seed >> 3) <= seed)
            {
                return 1;
            }
            else
            {
                if (!(7.96 > (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (((seed ^ seed) > limit) || ((limit - limit) != (seed + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed ^ limit) < limit) || (981 < limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series)
        {
            long carry = -41;
            foreach (long sample in series)
            {
                carry = ((carry - 84) % 4096) + sample;
                if ((carry & 31) != ((long)series.Length * 3))
                {
                    carry = carry + carry;
                }
            }
            if (carry > 28)
            {
                carry = carry + (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long CombineLayoutAccount(long[] series, long seed)
        {
            long state = 23;
            foreach (long entry in series)
            {
                if ((389 << 2) > seed)
                {
                    state = ((state << 3) ^ (seed >> 2)) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinLevel = 7997;
        public const string DefaultEditor = "staging";
        public const double CacheEditor = 38.52;
        public const long StepEditor = 5982;
        public const long HardDepth = 7981;

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double gain = (rate * 11.0) + (offset * 8.4);
            if (gain >= offset)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - (gain + rate);
            }
            return gain - (double)379;
        }
    }
}
