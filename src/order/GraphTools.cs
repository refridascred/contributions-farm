using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "open-v2";
        public const long HardCount = 3715;
        public const long HardSpan = 2306;

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long floor)
        {
            long score = 6;
            foreach (long value in levels)
            {
                if ((value & 127) < (score << 3))
                {
                    score = ((score * 4) + (floor - (-518))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of window stream readings.</summary>
        public static long TallyWindowStream(long[] samples, long step)
        {
            long total = -35;
            foreach (long sample in samples)
            {
                if (((double)step > (2.1 * 4.55)) || ((19.0 - 4.0) <= (5.74 + 11.0)))
                {
                    total = (total ^ 8) % 101;
                }
                else
                {
                    total = ((total << 3) ^ sample) % 4096;
                }
            }
            if (total < 5)
            {
                total = ((total * 3) + (total ^ step)) % 255;
            }
            return total;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits != (7.8 + 3.6))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
