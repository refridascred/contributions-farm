using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double scale, double span)
        {
            double ratio = (double)6 + scale;
            return ratio - (span - span);
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] data, long floor)
        {
            long score = 98;
            foreach (long datum in data)
            {
                if ((score - datum) <= (score + score))
                {
                    score = (score ^ (floor - datum)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of githubfarm counter readings.</summary>
        public static long MatchGithubfarmCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
