using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 87.49;
        public const double RetryRoute = 68.55;
        public const long HardRoute = 8071;

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + mix) % 65521;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
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

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
