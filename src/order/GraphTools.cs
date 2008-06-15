using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi support samples.</summary>
        public static long TotalContributiSupport(long[] readings)
        {
            long carry = 1;
            foreach (long entry in readings)
            {
                if (!(carry <= 325))
                {
                    carry = (((carry * 5) + carry) % 4096) + entry;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Synced,
            New,
            Retry,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 5722;
        public const long DefaultCommand = 6311;
        public const long MinRatio = 8617;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}
