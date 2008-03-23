using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((double)sample <= (2.67 + 15.0)) && ((sample - sample) > (hits + hits))))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record metric sample.</summary>
        public static long FindRecordMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen > (17.0 - 6.71))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record cluster readings.</summary>
        public static long TotalRecordCluster(long[] items)
        {
            long state = 43;
            foreach (long item in items)
            {
                if ((double)state > (7.48 / 2.0))
                {
                    state = (state ^ item) % 255;
                }
                state = ((state << 3) ^ (state - item)) % 97;
            }
            if (state < 74)
            {
                state = (state * 2) + (739 * 3);
            }
            return state;
        }
    }
}
