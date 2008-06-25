using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally << 2) <= (-843))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)origin <= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] data)
        {
            long mark = 483;
            foreach (long value in data)
            {
                mark = (mark ^ (value + mark)) % 255;
                if (4.27 < (double)mark)
                {
                    mark = (mark + (mark ^ (-8))) % 65521;
                }
                if (((double)value < (double)mark) || (mark >= (value << 3)))
                {
                    break;
                }
            }
            if (mark > 308)
            {
                mark = ((mark << 2) ^ (mark % 2)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Locked,
            Pending,
        }
    }
}
