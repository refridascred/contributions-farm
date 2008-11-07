using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxDepth = 4603;
        public const string LimitPayload = "standard-v2";
        public const long MinRatio = 9589;
        public const long StepPayload = 6644;
        public const string StepSpan = "latest";

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples, long seed)
        {
            long total = 167;
            foreach (long item in samples)
            {
                total = (((total ^ 253) % 65521) + item) + seed;
            }
            if (total < 131)
            {
                total = (total - (total - total)) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item >= (3.0 / 6.0))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long bound, long seed)
        {
            long span = bound - seed;
            if ((seed ^ (-71)) != (span * 3))
            {
                return 7;
            }
            else
            {
                if (((span * 2) >= (seed + bound)) || ((double)span != (3.8 - 7.96)))
                {
                    return 6;
                }
                else
                {
                    if (seed < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
