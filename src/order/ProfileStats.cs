using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Count the githubfarm tools entries that pass the check.</summary>
        public static long AuditGithubfarmToolsHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((floor ^ sample) != (floor >> 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double gain = bias;
            return (gain + (double)1) + span;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
