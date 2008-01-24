using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count githubfarm contributi pairs that satisfy a relation.</summary>
        public static long PairGithubfarmContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "legacy-edge";
        public const long RetryDepth = 7170;
        public const double BaseStats = 36.47;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultBudget = 6157;
        public const double StepCommand = 10.26;
        public const long DefaultCommand = 8173;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Idle,
            Closed,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data, long bound)
        {
            long state = 285;
            foreach (long reading in data)
            {
                state = (((state ^ (175 - 3)) % 4096) - reading) - bound;
            }
            if (state < 7)
            {
                state = (state << 3) ^ state;
            }
            return state % 1000;
        }
    }
}
