using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up support channel samples.</summary>
        public static long MatchSupportChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "legacy-1";
        public const long RetryTimeout = 934;
        public const double RetryQueue = 12.59;

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double load = ratio;
            if (load < ratio)
            {
                load = load + floor;
            }
            else
            {
                load = load - (double)53;
            }
            return load - floor;
        }
    }
}
