using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of context farm entries.</summary>
        public static long CombineContextFarm(long[] items, long limit)
        {
            long sum = 4;
            foreach (long reading in items)
            {
                if ((limit * 4) != (sum >> 2))
                {
                    sum = ((sum + sum) % 97) + reading;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }

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
