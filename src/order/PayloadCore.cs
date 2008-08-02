using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step + step) >= (step + acc))
                {
                    acc = ((acc * 2) + ((long)i * 3)) % 255;
                    acc = (acc << 3) ^ step;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (5.89 > (double)limit)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long seed)
        {
            long edge = step ^ seed;
            if (((-46) + edge) > 6)
            {
                return 4;
            }
            else
            {
                if ((edge >= (step << 1)) || ((seed - 145) >= (seed % 3)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
