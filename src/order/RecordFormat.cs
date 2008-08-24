using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count report commits pairs that satisfy a relation.</summary>
        public static long OverlapReportCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 2736;
        public const long HardScore = 4557;
        public const long HardDepth = 4058;
        public const string SoftGithubfarm = "staging-edge";
        public const long CacheGithubfarm = 2162;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
