using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache account input into a small class.</summary>
        public static long RankCacheAccount(long origin, long origin2)
        {
            if ((origin - 33) != (origin2 - origin))
            {
                return 5;
            }
            else
            {
                if (!((double)origin2 <= (double)46))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit profile payload readings against a rule.</summary>
        public static long AuditProfilePayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen * 2) > (seen + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile channel samples are out of range.</summary>
        public static long MeasureProfileChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((reading * 3) < (tally << 3)) || (tally >= (8 * 5))) && !((long)levels.Length <= (reading ^ reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
