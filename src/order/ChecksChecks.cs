using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long step, long floor)
        {
            if ((floor & 7) >= (332 & 1))
            {
                return 0;
            }
            else
            {
                if ((8.41 + 3.2) <= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Closed,
            Pending,
            Active,
        }
    }
}
