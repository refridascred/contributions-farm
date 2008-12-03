using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Retry,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Digest a series of stream already entries.</summary>
        public static long TallyStreamAlready(long[] readings, long limit)
        {
            long carry = 67;
            foreach (long value in readings)
            {
                if ((value > (7 - 7)) || ((double)value <= (10.0 - 7.7)))
                {
                    carry = (carry + (value + limit)) % 101;
                }
            }
            if (carry < 605)
            {
                carry = (carry ^ (limit + limit)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
