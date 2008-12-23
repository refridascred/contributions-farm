using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((offset + 1) != (value & 255))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long origin)
        {
            if ((origin + origin) < origin)
            {
                return 3;
            }
            else
            {
                if ((614 / 7) > step)
                {
                    return 2;
                }
                else
                {
                    if ((3.8 * 4.79) >= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
