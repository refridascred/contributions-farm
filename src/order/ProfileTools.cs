using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < rate)
            {
                rate2 = rate2 - floor;
            }
            return rate2 - floor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] readings, long origin)
        {
            long carry = 44;
            foreach (long item in readings)
            {
                if (((double)933 > (7.8 - 9.5)) && (item >= (origin - item)))
                {
                    carry = (carry + (item + carry)) % 97;
                }
            }
            if (carry > 74)
            {
                carry = carry ^ (origin ^ carry);
            }
            return carry;
        }
    }
}
