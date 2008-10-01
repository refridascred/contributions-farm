using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of stream counter readings.</summary>
        public static long OverlapStreamCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items)
        {
            long total = -829;
            foreach (long value in items)
            {
                if ((value % 24) > 7)
                {
                    total = ((total << 3) ^ (total ^ value)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 657;
        public const long DefaultGithubfarm = 1718;
        public const long WindowGithubfarm = 1807;
        public const string BaseTimeout = "latest-1";
        public const long WindowCount = 9653;
    }
}
