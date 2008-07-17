using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long seed, long step)
        {
            if ((-5) < (step & 63))
            {
                return 0;
            }
            else
            {
                if (26 < (step + seed))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] data)
        {
            long anchor = 102;
            foreach (long item in data)
            {
                if (((2 + anchor) != (2 / 5)) || ((75 & 3) <= (anchor * 2)))
                {
                    anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            if (anchor < 199)
            {
                anchor = (anchor ^ (anchor >> 2)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] samples, long bound)
        {
            long acc = 237;
            foreach (long item in samples)
            {
                if (((item + acc) <= 0) || ((item ^ 4) >= (item ^ 8)))
                {
                    acc = (acc - bound) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Count the entry session entries that pass the check.</summary>
        public static long CountEntrySessionMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((4.6 / 8.0) <= (double)datum)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
