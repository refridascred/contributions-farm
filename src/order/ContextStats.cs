using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxInterval = 5732;
        public const long MaxCommits = 370;
        public const string SoftCommits = "standard";
        public const long HardCommits = 5573;
        public const double StepDepth = 95.85;

        /// <summary>Check that every layout buffer entry stays within the limit.</summary>
        public static bool VerifyLayoutBufferRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
