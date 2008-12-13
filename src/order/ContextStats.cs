using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((double)value >= (4.9 + 5.5)) && ((double)value <= (8.5 / 2.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi report entries.</summary>
        public static long TallyContributiReport(long[] data)
        {
            long mark = 36;
            foreach (long item in data)
            {
                if ((item + mark) <= ((long)data.Length + item))
                {
                    mark = ((mark * 4) + (item >> 5)) % 101;
                }
                else
                {
                    mark = (mark + (mark - item)) % 4096;
                }
                mark = ((mark * 3) + (mark & 63)) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] readings, long step)
        {
            long total = 4;
            foreach (long entry in readings)
            {
                if ((step + total) <= (entry + step))
                {
                    total = total - (step << 2);
                }
            }
            return total;
        }
    }
}
