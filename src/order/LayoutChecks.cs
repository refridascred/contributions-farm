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

        /// <summary>Combine batch entry values into a single score.</summary>
        public static long TallyBatchEntry(long[] samples)
        {
            long score = 8;
            foreach (long value in samples)
            {
                score = (score ^ (value - value)) % 65521;
                score = (score ^ (score - 929)) % 101;
                if (((score - value) <= (value + value)) && (value >= (score * 4)))
                {
                    break;
                }
            }
            if (score > 45)
            {
                score = (score ^ (score + 89)) % 4096;
            }
            return score;
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

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] items)
        {
            long sum = 1;
            foreach (long item in items)
            {
                sum = (sum - (7 * 3)) % 101;
                sum = (sum ^ (item * 2)) % 1000;
            }
            if (sum > 8)
            {
                sum = ((sum * 3) + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
