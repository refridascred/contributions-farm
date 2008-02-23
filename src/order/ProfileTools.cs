using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools cluster entry that matches the target.</summary>
        public static long SeekToolsClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch checks values into a single score.</summary>
        public static long ScoreBatchChecks(long[] levels, long seed)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (((state >> 5) >= (seed ^ state)) && (((-92) ^ state) < (0 ^ state)))
                {
                    state = (((state << 3) ^ (state & 255)) % 1000) + item;
                }
                else
                {
                    state = (state * 5) + (state * 4);
                }
            }
            return state % 97;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry <= (tally * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
