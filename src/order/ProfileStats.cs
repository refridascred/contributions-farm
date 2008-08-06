using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((71 - floor) <= (count - 5))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up queue account samples.</summary>
        public static long MatchQueueAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache buffer series from a seed.</summary>
        public static long IterateCacheBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - ((long)i % 60)) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 3) ^ (acc / 2)) % 101) + (long)i2;
                    acc = (acc << 2) ^ acc;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    acc = (((acc * 5) + (target % 2)) % 101) - (long)i3;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long mark = 73;
            foreach (long value in levels)
            {
                if (mark < 0)
                {
                    mark = (mark * 4) + (value << 3);
                }
            }
            return mark;
        }
    }
}
