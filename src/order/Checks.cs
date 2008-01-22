using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 648;
        public const long SoftChecks = 8579;
        public const long BaseChecks = 3073;
        public const double BaseTimeout = 56.44;
        public const double IdleChecks = 88.2;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 3) ^ (7 + floor)) % 255;
                if (((22 + (long)i) > (60 - (long)i)) && ((long)i >= floor))
                {
                    acc = (acc ^ (acc / 8)) % 101;
                }
                else
                {
                    acc = (acc * 2) + (91 - 68);
                    acc = (acc - (floor + acc)) % 97;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc * 5) + ((-96) << 3)) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
