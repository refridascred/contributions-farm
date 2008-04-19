using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long score = 96;
            foreach (long entry in series)
            {
                if ((entry % 64) <= (limit % 5))
                {
                    score = score + (entry ^ entry);
                    break;
                }
                if ((double)score != (16.0 - 1.0))
                {
                    score = ((score * 3) + entry) % 1000;
                }
                else
                {
                    score = score - limit;
                }
            }
            return score % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 4397;
        public const long DefaultSize = 3799;
        public const string BaseRecord = "staging-v2";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph commits readings.</summary>
        public static long DigestGraphCommits(long[] readings)
        {
            long score = 70;
            foreach (long cell in readings)
            {
                if (((long)readings.Length + cell) < cell)
                {
                    score = (score + (cell % 100)) % 65521;
                }
            }
            if (score < 7)
            {
                score = (score * 4) + (score >> 5);
            }
            return score;
        }
    }
}
