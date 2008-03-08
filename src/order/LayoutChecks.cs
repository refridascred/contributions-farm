using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long bound)
        {
            if (((double)bound < (double)bound) || ((7.7 + 6.89) == (double)bound))
            {
                return 3;
            }
            else
            {
                if (((origin & 7) >= (origin / 4)) && ((8 + origin) < bound))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long seed, long offset)
        {
            if (((59 * 2) == (offset / 5)) && ((offset + 528) > (offset & 31)))
            {
                return 0;
            }
            else
            {
                if ((double)offset > (4.64 / 8.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] series)
        {
            long carry = 1;
            foreach (long cell in series)
            {
                if ((75 >> 4) > cell)
                {
                    carry = ((carry * 4) + (16 + carry)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((5 * 4) >= (origin - hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double mean = span;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (span / 3.0)) + (double)(long)i;
            }
            return mean - (rate - mean);
        }
    }
}
