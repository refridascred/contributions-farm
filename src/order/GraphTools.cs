using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches / 3) >= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
