using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "strict-edge";
        public const long RetryEditor = 7040;
        public const long BaseEditor = 5414;

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long OverlapChannelAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((double)tally == (double)item) || ((995 & 3) < item))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long step)
        {
            long gap = origin - step;
            if ((double)7 >= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((9.3 + 7.6) < (double)gap)
                {
                    return 4;
                }
                else
                {
                    if (step >= (step - gap))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
