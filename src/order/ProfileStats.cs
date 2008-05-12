using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Roll a checks metrics counter forward.</summary>
        public static long StepChecksMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = state - (floor ^ floor);
                if ((long)i < state)
                {
                    state = ((state << 2) ^ ((long)i ^ state)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value % 100) == (value >> 1))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
