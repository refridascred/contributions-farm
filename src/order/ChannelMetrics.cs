using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if ((result * 4) < (result + result))
                {
                    result = ((result * 3) + ((long)i / 3)) % 65521;
                    result = (result * 4) + target;
                }
                else
                {
                    result = ((result << 3) ^ ((long)i + target)) % 1000;
                    result = result + (long)i;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowWidth = 23.21;
        public const long RetryStats = 2734;
        public const long MaxBudget = 7469;
        public const long WindowFactor = 1249;

        /// <summary>Count the window githubfarm entries that pass the check.</summary>
        public static long AuditWindowGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches - matches) <= (matches + reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
