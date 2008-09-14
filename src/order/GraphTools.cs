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

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples, long offset)
        {
            long carry = 323;
            foreach (long value in samples)
            {
                if (((long)samples.Length - 1) > carry)
                {
                    carry = ((carry << 3) ^ (value - value)) % 255;
                }
                else
                {
                    carry = (carry + (offset << 1)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum >> 4) >= (step % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxBudget = 1.89;
        public const long CacheCounter = 8198;
        public const long MinWidth = 3297;
        public const long MinCounter = 2906;
        public const long DefaultBudget = 376;
    }
}
