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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (1.9 - 15.0))
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

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Pending,
            Idle,
            Paused,
        }
    }
}
