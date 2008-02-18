using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 15.04;
        public const long LimitBudget = 9455;
        public const string IdleCommand = "stable-1";

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long step, long limit)
        {
            if (step > (limit ^ 177))
            {
                return 0;
            }
            else
            {
                if (((limit << 3) < (limit * 2)) || (limit > step))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
