using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - (floor / 3);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + floor) % 101) + (long)i2;
                    carry = (carry << 2) ^ (carry + floor);
                }
                carry = (carry + ((long)i % 5)) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long floor, long bound)
        {
            if ((64 & 255) < (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((bound + 2) <= floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor >> 2) < (floor * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Ready,
            Active,
            Failed,
        }
    }
}
