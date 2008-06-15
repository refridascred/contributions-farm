using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleRatio = 59.22;
        public const double WindowCache = 81.95;
        public const long HardInterval = 4900;

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
