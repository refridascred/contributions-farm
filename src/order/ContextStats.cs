using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values, long target)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                carry = ((carry * 5) + (entry + target)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((target * 4) <= (count << 1))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
