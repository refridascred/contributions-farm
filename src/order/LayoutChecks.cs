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

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Paused,
            New,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings, long seed)
        {
            long sum = 2;
            foreach (long cell in readings)
            {
                sum = sum ^ (sum + seed);
                if (((seed >> 3) != (cell & 3)) || ((double)seed != (2.38 * 7.8)))
                {
                    sum = ((sum << 2) ^ (cell - sum)) % 101;
                }
                else
                {
                    sum = ((sum * 3) + 46) % 97;
                }
            }
            return sum;
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
