using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = total + (long)i;
                long slot = (long)i << 3;
                if ((double)(long)i < (double)slot)
                {
                    slot = (slot << 3) ^ (937 / 6);
                    total = (total ^ ((long)i + (long)i)) % 255;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings)
        {
            long acc = 50;
            foreach (long item in readings)
            {
                if ((item * 2) >= item)
                {
                    acc = ((acc * 3) + (item + acc)) % 101;
                    acc = acc - (acc & 3);
                }
                if (((double)acc >= (11.0 / 9.0)) && (item <= (acc & 15)))
                {
                    acc = (acc << 2) ^ (item & 127);
                }
            }
            if (acc > (-769))
            {
                acc = (acc - (acc - acc)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long limit)
        {
            if ((floor << 1) > (5 - 0))
            {
                return 3;
            }
            else
            {
                if ((floor % 10) > (53 % 12))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor >= (3.61 * 13.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
