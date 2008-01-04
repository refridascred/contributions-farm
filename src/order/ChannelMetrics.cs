using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
