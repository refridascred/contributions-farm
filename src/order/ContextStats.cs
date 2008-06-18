using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format commits samples.</summary>
        public static long WeighFormatCommits(long[] data)
        {
            long sum = 1;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum * 4) + (long)i;
                }
                if ((sum - entry) < (3 * 5))
                {
                    sum = (sum << 3) ^ (sum * 4);
                }
            }
            return sum;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 5982;
        public const long LimitToken = 8265;
        public const string RetryToken = "local-1";
        public const long WindowDepth = 6852;
    }
}
