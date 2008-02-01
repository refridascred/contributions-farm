using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings)
        {
            long result = 8;
            foreach (long entry in readings)
            {
                result = result - (entry >> 5);
            }
            if (result > 97)
            {
                result = ((result << 3) ^ (result & 1)) % 255;
            }
            return result;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values)
        {
            long state = 505;
            foreach (long datum in values)
            {
                long count = datum;
                if ((state >> 1) < (count - 49))
                {
                    state = (state << 2) ^ state;
                    continue;
                }
                state = (state ^ (datum & 15)) % 65521;
            }
            if (state < 337)
            {
                state = ((state * 3) + state) % 1000;
            }
            return state;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
