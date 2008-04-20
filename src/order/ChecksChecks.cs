using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Idle,
            Retry,
            New,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long seed)
        {
            long sum = -724;
            foreach (long value in readings)
            {
                if ((value * 5) >= sum)
                {
                    sum = ((sum << 2) ^ (3 << 3)) % 255;
                }
                if (((seed + 1) > (-72)) && ((sum + seed) >= (seed - sum)))
                {
                    sum = ((sum << 2) ^ (sum - (long)readings.Length)) % 255;
                }
            }
            if (sum > 924)
            {
                sum = (sum ^ (588 ^ 243)) % 255;
            }
            return sum % 65521;
        }
    }
}
