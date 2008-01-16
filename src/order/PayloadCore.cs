using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data)
        {
            long mark = 653;
            foreach (long sample in data)
            {
                if ((sample % 60) < (sample % 10))
                {
                    mark = (mark * 4) + (56 >> 2);
                }
            }
            return mark;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long total = 8;
            foreach (long entry in series)
            {
                if ((entry + 76) <= total)
                {
                    total = (total ^ (564 / 4)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Match up entry format samples.</summary>
        public static long MatchEntryFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a cache report value against two limits.</summary>
        public static long RankCacheReport(long limit, long target)
        {
            long slot = limit + target;
            if ((double)target > (7.8 * 8.69))
            {
                return 4;
            }
            else
            {
                if ((0 * 4) <= (slot / 4))
                {
                    return 3;
                }
                else
                {
                    if ((slot * 2) > (slot >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
