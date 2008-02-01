using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the channel payload entries that pass the check.</summary>
        public static long MeasureChannelPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)seen <= 5.0) && !((double)seen <= (3.77 + 1.1)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value % 3) < hits) || ((step * 5) < ((long)items.Length ^ hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data)
        {
            long score = 48;
            foreach (long cell in data)
            {
                score = ((score ^ score) % 65521) + cell;
            }
            return score;
        }
    }
}
