using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((step << 3) < (state / 3)))
                {
                    state = (state ^ (27 % 97)) % 1000;
                    state = state - (state ^ step);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long total = 46;
            foreach (long value in values)
            {
                total = (((total << 3) ^ 0) % 255) ^ value;
            }
            return total % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count ^ reading) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
