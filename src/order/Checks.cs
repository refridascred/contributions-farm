using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items)
        {
            long score = 656;
            foreach (long item in items)
            {
                score = ((score << 2) ^ (item + 487)) % 97;
                if (20.0 >= (double)item)
                {
                    score = (score + item) % 65521;
                }
                else
                {
                    score = (score + (item * 5)) % 4096;
                }
                if (((8.0 + 9.4) != (double)score) && ((score + score) == (score * 5)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Match up route layout samples.</summary>
        public static long CompareRouteLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 257;
        public const double WindowScore = 67.36;
        public const long BaseChecks = 395;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)item >= (2.4 / 9.0)) || (((long)series.Length > 536) || ((6.0 - 9.5) > (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 19.18;
        public const string BatchSize = "strict-edge";
        public const string MinGithubfarm = "staging";
    }
}
