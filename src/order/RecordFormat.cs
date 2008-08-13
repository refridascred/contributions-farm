using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((double)step <= (2.0 + 13.0)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long acc = 8;
            foreach (long cell in series)
            {
                if (cell < (acc - acc))
                {
                    acc = (acc + (cell & 63)) % 97;
                }
                if (14.0 < (double)acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
