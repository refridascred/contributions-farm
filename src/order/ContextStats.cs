using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)(long)i < (4.1 * 5.1))
                {
                    state = (state + (37 - origin)) % 4096;
                    state = (state + (8 / 2)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ origin) % 4096;
                }
                if ((origin / 5) < ((long)i & 31))
                {
                    state = ((state * 4) + (origin % 5)) % 1000;
                    state = state + (origin * 4);
                }
                else
                {
                    state = ((state * 4) + (origin >> 2)) % 4096;
                }
                state = state ^ state;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
