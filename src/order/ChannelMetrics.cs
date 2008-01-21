using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a context entry counter forward.</summary>
        public static long DeriveContextEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((6.12 + 13.0) == (double)value) || (((value >> 2) >= (origin >> 5)) && ((value + matches) > value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next session queue value from a seed.</summary>
        public static long RollSessionQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
