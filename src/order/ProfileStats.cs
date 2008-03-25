using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a notes stream counter forward.</summary>
        public static long IterateNotesStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc + (offset + acc)) % 101) ^ (long)i2;
                    acc = ((acc * 4) + (acc + acc)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches / 8) > (matches % 8))
                {
                    matches = ((matches + 1) + item) + seed;
                }
            }
            return matches;
        }
    }
}
