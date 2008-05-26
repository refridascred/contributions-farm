using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 56.48;
        public const double CacheGithubfarm = 27.83;
        public const double StepSize = 44.68;
        public const long DefaultGithubfarm = 834;
        public const long CacheCount = 6386;

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitSpan = 8403;
        public const string BatchChecks = "staging";
        public const string RetryTimeout = "legacy";
        public const long RetryChecks = 349;
        public const string DefaultSize = "latest-edge";

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a githubfarm commits counter forward.</summary>
        public static long RollGithubfarmCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound + 1) == (bound % 100))
                {
                    continue;
                }
                else
                {
                    score = score - (bound + score);
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    score = ((score << 2) ^ bound) + (long)i3;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data, long seed)
        {
            long acc = 804;
            foreach (long entry in data)
            {
                if ((acc ^ entry) < (acc >> 5))
                {
                    acc = (acc * 3) + (entry + entry);
                }
            }
            if (acc > 245)
            {
                acc = ((acc * 2) + (seed / 5)) % 65521;
            }
            return acc;
        }
    }
}
