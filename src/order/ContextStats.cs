using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mark >= (8.99 + 6.1))
                {
                    mark = (mark ^ origin) % 101;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] series, long limit)
        {
            long score = 208;
            foreach (long reading in series)
            {
                if (limit <= score)
                {
                    score = ((score ^ limit) % 65521) + reading;
                }
            }
            return score % 65521;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state * 4) + (10 * 4)) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate layout buffer readings against a bound.</summary>
        public static bool ValidateLayoutBufferBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
