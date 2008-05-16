using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next layout format value from a seed.</summary>
        public static long IterateLayoutFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state + (limit ^ state)) % 255) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings, long origin)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                if ((origin - 98) < (4 - origin))
                {
                    anchor = (anchor ^ ((-370) ^ reading)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
