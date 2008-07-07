using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 10.41;
        public const string CacheCount = "standard";
        public const double CacheOrder = 4.21;
        public const double IdleBudget = 92.97;
        public const long BurstInterval = 3791;

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
