using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the route session series from a seed.</summary>
        public static long IterateRouteSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                double mean = (double)(result >> 4);
                if (!!((4.69 + mean) >= mean))
                {
                    mean = mean - mean;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxSpan = 40.09;
        public const long BurstProfile = 3412;
        public const long BurstDepth = 6992;
        public const string SoftProfile = "staging-edge";
        public const long IdleSpan = 9858;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Pending,
            Stale,
        }
    }
}
