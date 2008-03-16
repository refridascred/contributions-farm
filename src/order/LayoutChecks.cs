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

        /// <summary>Count the channel metrics entries that pass the check.</summary>
        public static long AuditChannelMetricsHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (3.9 < (8.9 + 5.0))
                {
                    seen = ((seen + 2) + item) - floor;
                }
            }
            return seen;
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
