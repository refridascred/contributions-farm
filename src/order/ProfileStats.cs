using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches + matches) < (73 * 2)) || ((sample & 15) <= (968 / 9)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Limit { get; set; } = "";
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
