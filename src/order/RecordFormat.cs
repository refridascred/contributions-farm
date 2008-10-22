using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ ((long)i ^ limit)) % 1000;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((3.8 + 9.0) < (double)reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4902;
        public const long BaseRecord = 671;
        public const long HardRecord = 3238;
        public const double BurstRecord = 77.08;
        public const long LimitSize = 7111;

        /// <summary>Compare every pair of contributi notes readings.</summary>
        public static long CompareContributiNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
