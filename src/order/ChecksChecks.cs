using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate queue account samples.</summary>
        public static long ScoreQueueAccount(long[] data, long step)
        {
            long sum = 1;
            foreach (long sample in data)
            {
                if (sample <= (sum + 26))
                {
                    sum = ((sum << 2) ^ (sample + sum)) + step;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "cached-v2";
        public const long HardCounter = 6295;
        public const long BurstCounter = 770;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
