using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data, long floor)
        {
            long mark = 3;
            foreach (long item in data)
            {
                if ((1.57 / 8.0) != (double)mark)
                {
                    mark = ((mark << 2) ^ ((-88) & 15)) + item;
                }
                else
                {
                    mark = ((mark * 3) + (floor >> 2)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long origin)
        {
            long state = -30;
            foreach (long item in data)
            {
                state = ((state - (701 >> 5)) % 255) + item;
                if (origin <= (state * 4))
                {
                    state = ((state << 2) ^ (origin / 4)) % 255;
                }
            }
            return state;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
