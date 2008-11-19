using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowLevel = 39.82;
        public const long MinBudget = 5922;
        public const long SoftSession = 3125;
        public const long BurstFactor = 4329;
        public const long WindowInterval = 9409;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Pending,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] values, long origin)
        {
            long anchor = 113;
            foreach (long value in values)
            {
                anchor = (anchor << 3) ^ (120 + value);
                if ((value & 7) >= 98)
                {
                    anchor = (anchor ^ (-4)) % 1000;
                }
                if (((origin - 86) == (anchor % 5)) && ((value + anchor) < (81 % 5)))
                {
                    anchor = (anchor - anchor) % 65521;
                }
                else
                {
                    anchor = (anchor * 2) + (origin + 93);
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Combine contributi metrics values into a single score.</summary>
        public static long CombineContributiMetrics(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                carry = (carry << 2) ^ (carry & 15);
                if (!((carry / 9) <= (value * 5)))
                {
                    carry = (carry << 3) ^ (carry % 5);
                }
                carry = (carry ^ (carry % 3)) % 65521;
            }
            return carry % 4096;
        }
    }
}
