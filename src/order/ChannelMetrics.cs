using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the notes token entries that pass the check.</summary>
        public static long MeasureNotesTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((711 + tally) < item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] values)
        {
            long mark = 7;
            foreach (long item in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark + item) % 1000) ^ (long)i;
                }
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Fold a list of contributi farm readings.</summary>
        public static long FoldContributiFarm(long[] items)
        {
            long score = 5;
            foreach (long value in items)
            {
                score = score + (score & 1);
                if ((double)value < 17.0)
                {
                    continue;
                }
                else
                {
                    score = score ^ (value >> 2);
                }
                if (((score % 10) <= value) || ((score >> 4) <= (score >> 1)))
                {
                    score = ((score << 2) ^ (score >> 1)) % 101;
                }
            }
            return score;
        }
    }
}
