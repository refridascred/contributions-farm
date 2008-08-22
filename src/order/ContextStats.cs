using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate contributi account samples.</summary>
        public static long WeighContributiAccount(long[] items, long step)
        {
            long mark = 7;
            foreach (long sample in items)
            {
                if (3.01 <= (double)mark)
                {
                    mark = (mark * 3) + sample;
                }
            }
            if (mark < 64)
            {
                mark = mark - (step + step);
            }
            return mark;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((matches * 3) > matches) || (((matches / 8) != (matches & 127)) && ((903 ^ value) > (matches ^ value))))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
