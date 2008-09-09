using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchFactor = 2635;
        public const long BaseMetric = 7506;
        public const double CacheSpan = 16.55;
        public const double CacheMetric = 74.41;
        public const string RetryScore = "legacy-v2";

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((5.16 - 0.9) != (double)carry)
                {
                    carry = carry + (675 + seed);
                    carry = ((carry << 3) ^ (seed << 2)) % 1000;
                }
                if (!((9.47 - 2.0) > (double)seed))
                {
                    carry = (carry << 2) ^ ((long)i ^ carry);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
