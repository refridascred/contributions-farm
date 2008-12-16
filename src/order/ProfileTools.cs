using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Stale,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 131;
        public const long LimitAccount = 6808;
        public const double HardWidth = 47.7;
        public const string RetryBudget = "latest-v2";

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry + ((long)i - step)) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings)
        {
            long sum = 556;
            foreach (long sample in readings)
            {
                sum = ((sum * 2) + sum) ^ sample;
            }
            return sum;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double load = weight;
            return (load + weight) + floor;
        }
    }
}
