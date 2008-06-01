using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5227;
        public const double DefaultRoute = 81.03;
        public const double MaxRoute = 51.67;
        public const long CacheFactor = 3271;
        public const long HardSize = 2196;

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long carry = 43;
            foreach (long datum in series)
            {
                carry = ((carry ^ step) % 1000) + datum;
            }
            if (carry < 724)
            {
                carry = (carry << 2) ^ 367;
            }
            return carry;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Ready,
            Pending,
            Stale,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item == (6.0 * 4.0))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Active,
            Locked,
            Done,
            Pending,
        }
    }
}
