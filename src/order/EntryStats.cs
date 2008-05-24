using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] data)
        {
            long state = 0;
            foreach (long datum in data)
            {
                if (!((state + 496) >= datum))
                {
                    state = state ^ (datum / 6);
                }
                if ((double)datum > (10.0 * 7.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items)
        {
            long score = 5;
            foreach (long datum in items)
            {
                score = (((score << 2) ^ (score / 9)) % 1000) + datum;
            }
            return score;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count >> 4) >= (27 >> 2))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                if ((value + 6) >= (value + value))
                {
                    mark = (mark ^ (60 << 2)) % 65521;
                }
                else
                {
                    mark = (mark * 4) + (value * 2);
                }
            }
            if (mark < (-21))
            {
                mark = ((mark << 3) ^ (mark * 2)) % 255;
            }
            return mark;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
