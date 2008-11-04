using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the commits cache entries that pass the check.</summary>
        public static long MeasureCommitsCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((904 + tally) >= (item + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings, long step)
        {
            long score = 598;
            foreach (long sample in readings)
            {
                if ((sample / 3) <= (score + score))
                {
                    score = ((score - (score >> 4)) % 101) - step;
                }
            }
            if (score > 8)
            {
                score = (score + score) % 4096;
            }
            return score;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long step)
        {
            long state = 11;
            foreach (long cell in data)
            {
                if ((double)state != (6.54 - 1.81))
                {
                    state = ((((state << 2) ^ (state - state)) % 65521) - cell) - step;
                }
            }
            if (state < (-3))
            {
                state = (state - state) % 97;
            }
            return state;
        }
    }
}
