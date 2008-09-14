using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Retry,
            Done,
            Active,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long ScoreAlreadyRoute(long[] readings, long bound)
        {
            long total = 683;
            foreach (long entry in readings)
            {
                if ((total + entry) >= (16 + entry))
                {
                    total = (total - (entry & 7)) - bound;
                }
            }
            return total % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxBudget = 1.89;
        public const long CacheCounter = 8198;
        public const long MinWidth = 3297;
        public const long MinCounter = 2906;
        public const long DefaultBudget = 376;
    }
}
