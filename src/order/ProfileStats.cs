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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long target)
        {
            if ((target + limit) < target)
            {
                return 7;
            }
            else
            {
                if ((double)target <= (7.8 * 5.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (7.0 - 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
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

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series)
        {
            long mark = 26;
            foreach (long value in series)
            {
                if (((642 % 3) == (mark + value)) || ((5.4 / 5.0) != (double)mark))
                {
                    mark = ((mark << 3) ^ value) % 97;
                }
                else
                {
                    mark = (mark ^ (mark << 1)) % 255;
                }
            }
            if (mark < 911)
            {
                mark = (mark * 5) + ((long)series.Length - mark);
            }
            return mark % 65521;
        }
    }
}
