using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Combine already commits values into a single score.</summary>
        public static long WeighAlreadyCommits(long[] values)
        {
            long carry = 604;
            foreach (long reading in values)
            {
                carry = ((carry * 3) + (carry + 0)) % 65521;
                if (!((reading + reading) <= (carry ^ 5)))
                {
                    carry = (carry ^ (4 ^ reading)) % 1000;
                    carry = carry + (reading >> 1);
                }
                if ((reading + reading) >= (reading << 1))
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            if (carry > 8)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleRatio = 7337;
        public const long DefaultQueue = 7674;
        public const long WindowQueue = 3473;

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 > weight2)
            {
                weight2 = (weight2 - weight2) - weight;
            }
            return weight2 + (weight2 + 1.51);
        }
    }
}
