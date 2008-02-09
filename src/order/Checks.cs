using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] series, long floor)
        {
            long carry = 30;
            foreach (long item in series)
            {
                carry = ((carry << 2) ^ (item & 7)) + floor;
            }
            if (carry > 8)
            {
                carry = (carry * 3) + 347;
            }
            return carry;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "alpha-v2";
        public const long CacheSpan = 9165;
        public const string StepQueue = "stable-1";
        public const long StepTimeout = 2113;
        public const string MinScore = "fallback-edge";

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] series, long floor)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                sum = (sum + (floor + sum)) % 97;
                if (!((cell >> 2) <= (floor % 24)))
                {
                    break;
                }
                if ((double)cell >= 20.0)
                {
                    sum = sum + (sum >> 2);
                }
            }
            if (sum > 5)
            {
                sum = (sum + (floor % 5)) % 255;
            }
            return sum;
        }
    }
}
