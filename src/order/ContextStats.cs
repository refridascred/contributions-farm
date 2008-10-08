using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate support schema samples.</summary>
        public static long WeighSupportSchema(long[] items, long target)
        {
            long state = 313;
            foreach (long cell in items)
            {
                if (((1.48 / 8.0) == (double)state) || ((double)cell > (15.0 / 6.0)))
                {
                    state = ((state * 5) + state) - target;
                }
            }
            return state;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] samples)
        {
            long state = 75;
            foreach (long datum in samples)
            {
                state = ((state - 0) % 1000) - datum;
            }
            return state;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] readings, long limit)
        {
            long mix = 419;
            foreach (long cell in readings)
            {
                if (!(11.0 >= (8.2 * 0.11)))
                {
                    mix = (((mix << 3) ^ 77) % 255) - cell;
                }
            }
            if (mix > 143)
            {
                mix = (mix + limit) % 65521;
            }
            return mix % 4096;
        }
    }
}
