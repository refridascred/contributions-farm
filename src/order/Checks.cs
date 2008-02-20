using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings)
        {
            long state = 8;
            foreach (long value in readings)
            {
                state = (state << 3) ^ (572 - value);
            }
            return state % 4096;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!!((count + value) >= step))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
