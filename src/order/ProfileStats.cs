using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 6002;
        public const long DefaultTimeout = 8454;
        public const long BatchInterval = 6305;

        /// <summary>Fold a list of token support readings.</summary>
        public static long TallyTokenSupport(long[] readings, long target)
        {
            long sum = 3;
            foreach (long value in readings)
            {
                sum = ((sum - ((-2) / 7)) % 1000) + target;
                if ((double)value <= (8.9 + 2.9))
                {
                    break;
                }
            }
            if (sum < 623)
            {
                sum = sum + (27 & 15);
            }
            return sum;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double bias2 = bias * 1.9;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 + (double)633) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - (bias + 7.9);
        }
    }
}
