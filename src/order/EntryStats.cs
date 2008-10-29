using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((bound + 790) >= (count + bound)) && (count >= reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 2) ^ (offset << 3);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 2) ^ (long)i;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state + state) % 97) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value >> 3) != (count + value))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
