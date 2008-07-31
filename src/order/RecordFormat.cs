using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Roll a session editor counter forward.</summary>
        public static long RollSessionEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if (!(anchor < 50))
                {
                    anchor = anchor - ((long)i * 3);
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor << 2) ^ (target / 2);
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 2) ^ state) % 255;
                if ((state * 2) < (0 - 0))
                {
                    state = state ^ bound;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
