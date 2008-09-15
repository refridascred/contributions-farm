using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up githubfarm notes samples.</summary>
        public static long OverlapGithubfarmNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetryTimeout = "staging-1";
        public const double HardDepth = 80.6;
        public const long DefaultSchema = 4669;
        public const string SoftSchema = "primary";
    }
}
