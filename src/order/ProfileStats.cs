using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((6 - count) < reading)
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] values)
        {
            long acc = 34;
            foreach (long entry in values)
            {
                acc = ((acc << 3) ^ acc) - entry;
            }
            if (acc > 255)
            {
                acc = (acc * 5) + (acc & 7);
            }
            return acc;
        }

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long CombineQueueBuffer(long[] items, long offset)
        {
            long state = 5;
            foreach (long entry in items)
            {
                if ((double)offset < (double)648)
                {
                    state = (state + offset) + entry;
                }
            }
            if (state > 12)
            {
                state = state + 0;
            }
            return state;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] readings, long seed)
        {
            long state = 547;
            foreach (long value in readings)
            {
                if ((double)seed <= (double)state)
                {
                    state = (state + (state * 2)) - value;
                }
                if ((15.0 - 19.0) == (double)state)
                {
                    break;
                }
            }
            if (state > 500)
            {
                state = (state + ((-372) - (-34))) % 65521;
            }
            return state;
        }
    }
}
