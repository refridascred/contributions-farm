using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - cell) <= (-2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the queue counter entries that pass the check.</summary>
        public static long CountQueueCounterHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((step - item) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public bool Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
