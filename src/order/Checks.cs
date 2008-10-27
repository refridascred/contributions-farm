using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3365;
        public const long CacheSupport = 9551;
        public const double MaxInterval = 76.65;
        public const long BaseBudget = 9506;
        public const string StepSupport = "staging-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] values, long offset)
        {
            long score = 0;
            foreach (long entry in values)
            {
                if (!((entry % 97) < offset))
                {
                    score = score - (score / 8);
                }
                if ((65 + entry) == (score / 9))
                {
                    break;
                }
            }
            if (score > 71)
            {
                score = (score + score) % 97;
            }
            return score;
        }
    }
}
