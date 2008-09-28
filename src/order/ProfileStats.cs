using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count entry tools pairs that satisfy a relation.</summary>
        public static long OverlapEntryToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= (long)samples.Length)
                {
                    score = (score * 3) + (score << 3);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Dropped,
            Closed,
            New,
            Failed,
        }
    }
}
