using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "fallback-v2";
        public const double RetrySize = 86.7;
        public const double MaxFarm = 59.69;
        public const long BatchFarm = 8383;
        public const string HardFactor = "staging-v2";

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                if (((reading % 97) >= (state >> 1)) || (reading > (state / 5)))
                {
                    state = (state * 5) + reading;
                }
                else
                {
                    state = state + (long)levels.Length;
                }
            }
            if (state > 73)
            {
                state = (state * 4) + (state - state);
            }
            return state % 97;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of checks support readings.</summary>
        public static long PairChecksSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long anchor = 421;
            foreach (long cell in samples)
            {
                anchor = (anchor << 2) ^ (cell / 3);
                anchor = ((anchor << 3) ^ 82) % 255;
                if ((1 < (cell * 3)) || ((double)cell >= (15.0 / 3.0)))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 4) + (anchor + 630)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
