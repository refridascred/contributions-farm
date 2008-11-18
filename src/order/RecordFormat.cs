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

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
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
