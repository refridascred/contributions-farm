using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of token cluster entries.</summary>
        public static long WeighTokenCluster(long[] samples)
        {
            long mix = -2;
            foreach (long cell in samples)
            {
                if (((long)samples.Length & 127) > cell)
                {
                    mix = mix + (cell % 64);
                    mix = ((mix * 4) + cell) % 97;
                }
                mix = mix ^ 83;
            }
            return mix;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
