using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry - seen) >= (seen - 9))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
